using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class StorageEditForm : Form
    {
        private RPN_API_Web web;
        int storage_id = -1;

        public StorageEditForm(RPN_API_Web web, int storage_id)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            storageFormSkin.FlatColor = Program.UIColor;

            storageTypeFlatComboBox.HoverColor = Program.UIColor;
            ownerFlatComboBox.HoverColor = Program.UIColor;

            this.web = web;
            this.storage_id = storage_id;

            try
            {
                foreach (RPN_API_Json.InternalData data in web.GetAllUsers())
                    ownerFlatComboBox.Items.Add(data.Username);
            }
            catch
            {
                MessageBox.Show("Impossible de charger les membres du groupe !");
            }

            try
            {
                foreach (RPN_API_Json.StorageTypeData data in web.GetStorageType())
                    storageTypeFlatComboBox.Items.Add(data.Name);
            }
            catch
            {
                MessageBox.Show("Impossible de charger les types de stockages !");
            }

            if (storage_id != -1)
            {
                RPN_API_Json.Storage storage = web.GetStorageFromId(storage_id);
                nameFlatTextBox.Text = storage.Name;
                ownerFlatComboBox.Text = storage.Owner;
                storageTypeFlatComboBox.Text = web.GetStorageTypeFromId(storage.StorageTypeId).Name;
                locationFlatTextBox.Text = storage.Location;
            }
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            int storage_type_id = -1;
            if (string.IsNullOrWhiteSpace(nameFlatTextBox.Text))
            {
                MessageBox.Show("Vous n'avez pas renseigné de nom pour le stocakge !");
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

            if (ownerFlatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez pas renseigné de propriétaire pour le stocakge !");
                return;
            }

            if (storageTypeFlatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez pas renseigné de type pour le stocakge !");
                return;
            }

            foreach (RPN_API_Json.StorageTypeData data in web.GetStorageType())
                if (data.Name.Equals(storageTypeFlatComboBox.Text))
                    storage_type_id = data.Id;

            if (storage_type_id == -1)
            {
                MessageBox.Show("Impossible de déterminer le type de stockage !");
                return;
            }

            try
            {
                if (storage_id != -1)
                {
                    if (!web.EditStorage(storage_id, nameFlatTextBox.Text, ownerFlatComboBox.Text, storage_type_id, locationFlatTextBox.Text))
                        MessageBox.Show("Impossible d'éditer le Stockage !", "Erreur");
                }
                else
                {
                    if (!web.CreateStorage(nameFlatTextBox.Text, ownerFlatComboBox.Text, storage_type_id, locationFlatTextBox.Text))
                        MessageBox.Show("Impossible de créer le Stockage !", "Erreur");
                }
            }
            catch
            {
                MessageBox.Show("Impossible de créer le Stockage !", "Erreur");
            }
            Close();
        }
    }

}
