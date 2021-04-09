using RolePlay_Notes.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class StorageRessourceTypeEditForm : Form
    {
        private RPN_API_Web web;
        private int id;

        public StorageRessourceTypeEditForm(RPN_API_Web web, int id)
        {
            InitializeComponent();

            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            storageRessourceTypeFormSkin.FlatColor = Program.UIColor;

            this.web = web;
            this.id = id;

            // Load Storage Ressource
            if (id != -1)
            {
                RPN_API_Json.RessourceTypeData data = web.GetRessourceTypeFromId(id);
                nameFlatTextBox.Text = data.Name;
                massNumericUpDown.Value = data.Mass;
                priceNumericUpDown.Value = data.Price;
                if (data.Icon != null)
                    ressourcePictureBox.Image = web.Base64ToImage(data.Icon);
            }

        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameFlatTextBox.Text)
                 || string.IsNullOrWhiteSpace(nameFlatTextBox.Text))
            {
                MessageBox.Show("Vous n'avez pas défini de nom pour la ressource !", "Merci de définir un nom de ressource");
                return;
            }

            try
            {
                if (id == -1)
                {
                    foreach (RPN_API_Json.RessourceTypeData ressourceTypeData in web.GetRessourceType())
                    {
                        if (ressourceTypeData.Name.Equals(nameFlatTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                        {
                            MessageBox.Show("Une ressource porte déjà ce nom !");
                            return;
                        }
                    }

                    if (!web.CreateRessourceType(nameFlatTextBox.Text,
                        (int)massNumericUpDown.Value,
                        (int)priceNumericUpDown.Value,
                        ressourcePictureBox.Image))
                    {
                        throw new Exception("API ERROR");
                    }
                }
                else
                {
                    if (!web.EditRessourceType(id,
                        nameFlatTextBox.Text,
                        (int)massNumericUpDown.Value,
                        (int)priceNumericUpDown.Value,
                        ressourcePictureBox.Image))
                    {
                        throw new Exception("API ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur a eu lieu pendant l'envoie du type de ressource !\n" +
                    ex.Message, "Erreur");
            }
            Close();
        }

        private void cancelFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectIconFlatButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ressourceImageOpenFileDialog = new OpenFileDialog
            {
                Title = "Sélectionner une Image (64x64) !",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "png",
                Filter = "Image (64x64) (*.png)|*.png",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (ressourceImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image;
                try
                {
                    image = Image.FromFile(ressourceImageOpenFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Il semblerait que le fichier ne soit pas une image !", "Image Invalide");
                    return;
                }

                if (image.Width != image.Height)
                {
                    MessageBox.Show("L'image n'est pas un carré !", "Aspect de l'Image");
                    return;
                }

                if (image.Width != 64 || image.Height != 64)
                {
                    MessageBox.Show("RPN va automatiquement ajuster la résolution de votre image.\n" +
                        "Taille Max = 64x64", "Résolution de l'Image");
                    image = (Image)(new Bitmap(image, new Size(64, 64)));
                }

                if (web.ImageToBase64(image).Length > 16000)
                {
                    MessageBox.Show("L'image est trop lourd !", "Taille du fichier trop importante");
                    return;
                }

                ressourcePictureBox.Image = image;
            }
        }
    }
}
