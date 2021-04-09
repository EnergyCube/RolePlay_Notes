using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class StorageForm : Form
    {
        private RPN_API_Web web;

        public StorageForm(RPN_API_Web web)
        {
            InitializeComponent();

            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            stockFormSkin.FlatColor = Program.UIColor;

            storageDataGridView.Columns.Add("id", "ID");
            storageDataGridView.Columns.Add("name", "Nom");

            storageDataGridView.Columns[0].Visible = false;
            storageDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storageDataGridView.AllowUserToResizeRows = false;

            storageDetailDataGridView.Columns.Add("id", "ID");
            storageDetailDataGridView.Columns.Add("ressource_id", "Ressource");
            storageDetailDataGridView.Columns.Add("quantity", "Quantité");
            storageDetailDataGridView.Columns.Add("mass", "Occupation");

            storageDetailDataGridView.Columns[0].Visible = false;
            storageDetailDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storageDetailDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storageDetailDataGridView.AllowUserToResizeRows = false;


            storageTypeDataGridView.Columns.Add("id", "ID");
            storageTypeDataGridView.Columns.Add("name", "Nom");
            storageTypeDataGridView.Columns.Add("size", "Poid Maximal");

            storageTypeDataGridView.Columns[0].Visible = false;
            storageTypeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storageTypeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storageTypeDataGridView.AllowUserToResizeRows = false;


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            img.DefaultCellStyle.NullValue = null;
            ressourceTypeDataGridView.Columns.Add(img);
            ressourceTypeDataGridView.Columns.Add("id", "ID");
            ressourceTypeDataGridView.Columns.Add("name", "Nom");
            ressourceTypeDataGridView.Columns.Add("size", "Poid");
            ressourceTypeDataGridView.Columns.Add("price", "Prix Unitaire");

            ressourceTypeDataGridView.Columns[1].Visible = false;
            ressourceTypeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ressourceTypeDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ressourceTypeDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ressourceTypeDataGridView.RowTemplate.Height = 48;
            ressourceTypeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ressourceTypeDataGridView.AllowUserToResizeRows = false;

            this.web = web;
            ReloadData();
        }

        private void addFlatButton_Click(object sender, EventArgs e)
        {
            if (storageFlatTabControl.SelectedIndex == 0)
            {
                new StorageEditForm(web, -1).ShowDialog();
                ReloadData();
            }
            else if (storageFlatTabControl.SelectedIndex == 1)
            {
                new StorageRessourceTypeEditForm(web, -1).ShowDialog();
                ReloadData();
            }
            else if (storageFlatTabControl.SelectedIndex == 2)
            {
                new StorageTypeEditForm(web, -1).ShowDialog();
                ReloadData();
            }
        }

        private void editFlatButton_Click(object sender, EventArgs e)
        {
            if (storageFlatTabControl.SelectedIndex == 0)
            {
                if (storageDataGridView.SelectedCells.Count > 0)
                {
                    int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                    new StorageEditForm(web, storage_id).ShowDialog();
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de stockage !");
                    return;
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 1)
            {
                if (ressourceTypeDataGridView.SelectedRows.Count > 0)
                {
                    int id = int.Parse(ressourceTypeDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    new StorageRessourceTypeEditForm(web, id).ShowDialog();
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de ressource !");
                    return;
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 2)
            {
                if (storageTypeDataGridView.SelectedRows.Count > 0)
                {
                    int id = int.Parse(storageTypeDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    new StorageTypeEditForm(web, id).ShowDialog();
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de stockage !");
                    return;
                }
            }
        }

        private void refreshFlatButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadStorageDetailData(int storage_id)
        {
            storageDetailDataGridView.Rows.Clear();

            if (storage_id != -1)
            {
                int space_used = 0;
                int pc_used;
                foreach (RPN_API_Json.StorageData storageData in web.GetStorageDataFromStorageId(storage_id))
                {
                    RPN_API_Json.RessourceTypeData ressourceTypeData = web.GetRessourceTypeFromId(storageData.RessourceType);
                    storageDetailDataGridView.Rows.Add(storageData.Id, ressourceTypeData.Name, storageData.Quantity, storageData.Quantity * ressourceTypeData.Mass); ;
                    space_used += ressourceTypeData.Mass * storageData.Quantity;
                }

                RPN_API_Json.Storage storage = web.GetStorageFromId(storage_id);
                RPN_API_Json.StorageTypeData storageType = web.GetStorageTypeFromId(storage.StorageTypeId);

                storageTypeFlatLabel.Text = "Type : " + storageType.Name;
                pc_used = (int)(((float)space_used / (float)storageType.Size) * 100);
                storageSizeflatLabel.Text = "Taille : " + space_used.ToString("N0") + "/" + storageType.Size.ToString("N0") + " (Soit " + pc_used + "%)";
                if (pc_used >= 100)
                    flatProgressBar1.Value = 100;
                else if (pc_used <= 0)
                    flatProgressBar1.Value = 0;
                else
                    flatProgressBar1.Value = pc_used;
                ownerFlatLabel.Text = storage.Owner;
            }
            else
            {
                storageTypeFlatLabel.Text = "Type : X";
                storageSizeflatLabel.Text = "Taille : X/X (Soit XX%)";
                flatProgressBar1.Value = 100;
                quantityFlatLabel.Text = "Quantité : X";
                unitPriceFlatLabel.Text = "Prix Unitaire : X€";
                rentFlatLabel.Text = "X€";
            }

            storageDetailDataGridView.Refresh();
        }

        private void ReloadData()
        {
            ressourceTypeDataGridView.Rows.Clear();
            storageTypeDataGridView.Rows.Clear();
            storageDataGridView.Rows.Clear();

            ReloadStorageDetailData(-1);

            foreach (RPN_API_Json.Storage data in web.GetStorages())
            {
                storageDataGridView.Rows.Add(data.Id, data.Name);
            }

            foreach (RPN_API_Json.RessourceTypeData data in web.GetRessourceType())
            {
                if (data.Icon != null)
                    ressourceTypeDataGridView.Rows.Add(web.Base64ToImage(data.Icon), data.Id, data.Name, data.Mass, data.Price);
                else
                    ressourceTypeDataGridView.Rows.Add(Resources.package_tracking, data.Id, data.Name, data.Mass, data.Price);
            }

            foreach (RPN_API_Json.StorageTypeData data in web.GetStorageType())
            {
                storageTypeDataGridView.Rows.Add(data.Id, data.Name, data.Size);
            }

            ressourceTypeDataGridView.Refresh();
            storageTypeDataGridView.Refresh();
            storageDataGridView.Refresh();
        }

        private void deleteFlatButton_Click(object sender, EventArgs e)
        {
            if (storageFlatTabControl.SelectedIndex == 0)
            {
                if (storageDataGridView.SelectedCells.Count > 0)
                {
                    int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                    string name = storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    DeleteThings(storage_id, name);
                    ReloadData();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de stockage !");
                    return;
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 1)
            {
                if (ressourceTypeDataGridView.SelectedRows.Count > 0)
                {
                    int id = int.Parse(ressourceTypeDataGridView.Rows[ressourceTypeDataGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
                    string name = ressourceTypeDataGridView.Rows[ressourceTypeDataGridView.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    DeleteThings(id, name);
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de ressource !");
                    return;
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 2)
            {
                if (storageTypeDataGridView.SelectedRows.Count > 0)
                {
                    int id = int.Parse(storageTypeDataGridView.Rows[storageTypeDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                    string name = storageTypeDataGridView.Rows[storageTypeDataGridView.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    DeleteThings(id, name);
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas selectionné de ressource !");
                    return;
                }
            }
        }

        // NomDeFonction/20
        private void DeleteThings(int id, string name)
        {
            if (storageFlatTabControl.SelectedIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show
                ("Voulez vous vraiment supprimer le stockage n°" + id + " ('" + name + "') ?\n" +
                "Toutes les données associées seront supprimées !",
                "Supprimer le stockage ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (!web.DeleteStorage(id))
                            throw new Exception("API ERROR");
                        ReloadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression du stockage !\n" +
                            "Erreur : " + ex.Message, "Erreur");
                    }
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show
                ("Voulez vous vraiment supprimer le type de ressource n°" + id + " ('" + name + "') ?\n" +
                "Les stockages qui utilisent cette ressource seront conservée MAIS la ressource sera supprimée !",
                "Supprimer le type de ressource ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (!web.DeleteRessourceType(id))
                            throw new Exception("API ERROR");
                        ReloadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression de la ressource !\n" +
                            "Erreur : " + ex.Message, "Erreur");
                    }
                }
            }
            else if (storageFlatTabControl.SelectedIndex == 2)
            {
                DialogResult dialogResult = MessageBox.Show
                   ("Voulez vous vraiment supprimer le type de stockage n°" + id + " ('" + name + "') ?\n" +
                   "Les stockages qui utilisent ce moyen d'identification peuvent dysfonctionner mais garderont leurs données\n" +
                   "Retenez qu'il est possible de simplement changer le nom ou la taille en utilisant le bouton 'Modifier' !",
                   "Supprimer le type de stockage ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (!web.DeleteStorageType(id))
                            throw new Exception("API ERROR");
                        ReloadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression du type de stockage !\n" +
                            "Erreur : " + ex.Message, "Erreur");
                    }
                }
            }
        }

        private void storageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (storageDataGridView.SelectedCells.Count > 0)
            {
                int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                ReloadStorageDetailData(storage_id);
            }
        }

        private void addDataFlatButton_Click(object sender, EventArgs e)
        {
            if (storageDataGridView.SelectedCells.Count > 0)
            {
                int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                new StorageDataEditForm(web, storage_id, -1).ShowDialog();
                ReloadStorageDetailData(storage_id);
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un stockage !");
            }
        }

        private void editDataFlatButton_Click(object sender, EventArgs e)
        {
            if (storageDataGridView.SelectedCells.Count > 0)
            {
                int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                int storage_data_id = int.Parse(storageDetailDataGridView.Rows[storageDetailDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                new StorageDataEditForm(web, storage_id, storage_data_id).ShowDialog();
                ReloadStorageDetailData(storage_id);
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un stockage !");
            }
        }

        private void deleteDataFlatButton_Click(object sender, EventArgs e)
        {
            if (storageDataGridView.SelectedCells.Count > 0)
            {
                int storage_id = int.Parse(storageDataGridView.Rows[storageDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                int storage_data_id = int.Parse(storageDetailDataGridView.Rows[storageDetailDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                web.DeleteStorageData(storage_data_id);
                ReloadStorageDetailData(storage_id);
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un stockage !");
            }
        }

        private void storageDetailDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (storageDetailDataGridView.SelectedCells.Count > 0)
            {
                int storage_data_id = int.Parse(storageDetailDataGridView.Rows[storageDetailDataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

                RPN_API_Json.StorageData storageData = web.GetStorageDataFromId(storage_data_id);

                RPN_API_Json.RessourceTypeData ressourceType = web.GetRessourceTypeFromId(storageData.RessourceType);
                quantityFlatLabel.Text = "Quantité : " + storageData.Quantity.ToString("N0");
                unitPriceFlatLabel.Text = "Prix Unitaire : " + ressourceType.Price.ToString("C0");
                rentFlatLabel.Text = (storageData.Quantity * ressourceType.Price).ToString("C0");
                belongToFlatLabel.Text = storageData.BelongTo;
            }
        }

    }
}
