using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class StorageTypeEditForm : Form
    {
        private RPN_API_Web web;
        private int id;

        public StorageTypeEditForm(RPN_API_Web web, int id)
        {
            InitializeComponent();

            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            storageTypeFormSkin.FlatColor = Program.UIColor;

            this.web = web;
            this.id = id;

            // Load Storage Ressource
            if (id != -1)
            {
                RPN_API_Json.StorageTypeData data = web.GetStorageTypeFromId(id);
                nameFlatTextBox.Text = data.Name;
                sizeNumericUpDown.Value = data.Size;
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
                MessageBox.Show("Vous n'avez pas défini de nom pour le stockage !", "Merci de définir un nom de stockage");
                return;
            }

            foreach (RPN_API_Json.StorageTypeData storageTypeData in web.GetStorageType())
            {
                if (storageTypeData.Name.Equals(nameFlatTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Un stockage porte déjà ce nom !");
                    return;
                }
            }

            try
            {
                if (id == -1)
                {
                    if (!web.CreateStorageType(nameFlatTextBox.Text,
                        (int)sizeNumericUpDown.Value))
                    {
                        throw new Exception("API ERROR");
                    }
                }
                else
                {
                    if (!web.EditStorageType(id, nameFlatTextBox.Text,
                        (int)sizeNumericUpDown.Value))
                    {
                        throw new Exception("API ERROR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur a eu lieu pendant l'envoie du type de stockage !\n" +
                    ex.Message, "Erreur");
            }
            Close();
        }

        private void cancelFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
