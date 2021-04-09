using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class StorageDataEditForm : Form
    {
        private RPN_API_Web web;
        int storage_id = -1;
        int storage_data_id = -1;

        public StorageDataEditForm(RPN_API_Web web, int storage_id, int storage_data_id)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            storageDataFormSkin.FlatColor = Program.UIColor;

            ressourceTypeFlatComboBox.HoverColor = Program.UIColor;
            belongtoFlatComboBox.HoverColor = Program.UIColor;

            this.web = web;
            this.storage_id = storage_id;
            this.storage_data_id = storage_data_id;


            foreach (RPN_API_Json.RessourceTypeData ressourceTypeData in web.GetRessourceType())
            {
                ressourceTypeFlatComboBox.Items.Add(ressourceTypeData.Name);
            }

            foreach (RPN_API_Json.InternalData internalData in web.GetAllUsers())
            {
                belongtoFlatComboBox.Items.Add(internalData.Username);
            }

            if (storage_data_id != -1)
            {
                RPN_API_Json.StorageData currentStorageData = web.GetStorageDataFromId(storage_data_id);
                RPN_API_Json.RessourceTypeData currentRessourceType = web.GetRessourceTypeFromId(currentStorageData.RessourceType);
                RPN_API_Json.InternalData currentBelongTo = web.GetUser(currentStorageData.BelongTo);

                foreach (RPN_API_Json.RessourceTypeData ressourceTypeData in web.GetRessourceType())
                {
                    if (currentRessourceType.Name.Equals(ressourceTypeData.Name, StringComparison.InvariantCultureIgnoreCase))
                        ressourceTypeFlatComboBox.Text = ressourceTypeData.Name;
                }

                foreach (RPN_API_Json.InternalData internalData in web.GetAllUsers())
                {
                    if (currentBelongTo.Username.Equals(internalData.Username, StringComparison.InvariantCultureIgnoreCase))
                        belongtoFlatComboBox.Text = internalData.Username;
                }

                quantityNumericUpDown.Value = currentStorageData.Quantity;
            }
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            int ressource_type_id = -1;

            if (quantityNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Merci de renseigner une quantité pour cette ressource !");
                return;
            }

            if (belongtoFlatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Merci de renseigner un propriétaire pour cette ressource !");
                return;
            }

            if (ressourceTypeFlatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Merci de renseigner un type de ressource !");
                return;
            }

            foreach (RPN_API_Json.RessourceTypeData data in web.GetRessourceType())
                if (data.Name.Equals(ressourceTypeFlatComboBox.Text))
                    ressource_type_id = data.Id;

            if (ressource_type_id == -1)
            {
                MessageBox.Show("Impossible de déterminer le type de ressource !");
                return;
            }

            if (storage_data_id != -1)
            {
                web.EditStorageData(storage_data_id, ressource_type_id, (int)quantityNumericUpDown.Value, belongtoFlatComboBox.Text, storage_id);
            }
            else
            {
                web.CreateStorageData(ressource_type_id, (int)quantityNumericUpDown.Value, belongtoFlatComboBox.Text, storage_id);
            }
            Close();
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
