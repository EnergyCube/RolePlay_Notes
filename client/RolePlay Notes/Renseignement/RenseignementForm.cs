using RolePlay_Notes.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class RenseignementForm : Form
    {
        private RPN_API_Web web;

        public RenseignementForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            renseignementFormSkin.FlatColor = Program.UIColor;

            renseignementDataGridView.Columns.Add("Id", "ID");
            renseignementDataGridView.Columns.Add("nickname", "Nom");
            renseignementDataGridView.Columns.Add("name", "Prénom");
            renseignementDataGridView.Columns.Add("pseudo", "Pseudo");
            renseignementDataGridView.Columns.Add("tel", "Tel");
            renseignementDataGridView.Columns.Add("affiliation", "Affiliations");
            renseignementDataGridView.Columns.Add("financial_situation", "Situation Financière");
            renseignementDataGridView.Columns.Add("behaviour", "Comportement");
            renseignementDataGridView.Columns.Add("dead", "Mort(e)");
            renseignementDataGridView.Columns.Add("wanted", "Recherché(e)");
            renseignementDataGridView.Columns.Add("fake_name", "Faux Prénom");
            renseignementDataGridView.Columns.Add("fake_nickname", "Faux Nom");

            renseignementDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            renseignementDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            renseignementDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            renseignementDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            renseignementDataGridView.AllowUserToResizeRows = false;

            this.web = web;

            ReloadData();
        }

        private void ReloadData()
        {
            editFlatButton.Enabled = false;
            addFlatButton.Enabled = false;
            deleteFlatButton.Enabled = false;
            refreshFlatButton.Enabled = false;
            renseignementDataGridView.Rows.Clear();
            renseignementDataGridView.Enabled = false;
            renseignementDataGridView.Refresh();

            rowNbFlatLabel.Text = "Récupération des fiches de renseignements...";

            List<RPN_API_Json.RenseignementData> data = null;
            try
            {
                data = web.GetRenseignements(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupérations des renseignements !\n" +
                    "Error : " + ex.Message);
            }

            if (data != null)
            {
                rowNbFlatLabel.Text = "Vous avez " + data.Count.ToString() + " fiches de renseignements";

                foreach (RPN_API_Json.RenseignementData rensData in data)
                {
                    renseignementDataGridView.Rows.Add(rensData.Id, rensData.Nickname, rensData.Name,
                        rensData.Pseudo, rensData.Tel, rensData.Affiliation, rensData.FinancialSituation,
                        rensData.Behaviour, rensData.Dead, rensData.Wanted,
                        rensData.FakeNickname, rensData.FakeName); ;
                }
            }

            renseignementDataGridView.PerformLayout();
            renseignementDataGridView.Enabled = true;
            renseignementDataGridView.Refresh();
            editFlatButton.Enabled = true;
            addFlatButton.Enabled = true;
            deleteFlatButton.Enabled = true;
            refreshFlatButton.Enabled = true;
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPlayerFlatButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                Program.IsFullscreen = true;
            else
                Program.IsFullscreen = false;

            new RenseignementEditForm(web, -1).ShowDialog();
            ReloadData();
        }

        private void editFlatButton_Click(object sender, EventArgs e)
        {
            if (renseignementDataGridView.SelectedRows.Count > 0)
            {
                new RenseignementEditForm(web,
                    int.Parse(renseignementDataGridView.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
                ReloadData();
            }
            else if (renseignementDataGridView.SelectedCells.Count > 0)
            {
                new RenseignementEditForm(web,
                    int.Parse(renseignementDataGridView.Rows[renseignementDataGridView.SelectedCells[0].RowIndex]
                        .Cells[0].Value.ToString())).ShowDialog();
                ReloadData();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de renseignement !");

            }
        }

        private void renseignementDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new RenseignementEditForm(web,
                int.Parse(renseignementDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
            ReloadData();
        }

        private void refreshFlatButton_Click(object sender, EventArgs e)
        {
            refreshFlatButton.Enabled = false;
            ReloadData();
        }

        private void deleteFlatButton_Click(object sender, EventArgs e)
        {
            if (renseignementDataGridView.SelectedRows.Count > 0)
            {
                int id = int.Parse(renseignementDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Êtes vous vraiment sûr de vouloir supprimer la fiche de " +
                "renseignement n°" + id.ToString() + " ?", "Confirmation de Suppression !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    web.DeleteRenseignements(id);
                }

                ReloadData();
            }
            else if (renseignementDataGridView.SelectedCells.Count > 0)
            {
                int id = int.Parse(renseignementDataGridView.Rows[renseignementDataGridView.SelectedCells[0].RowIndex]
                        .Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Êtes vous vraiment sûr de vouloir supprimer la fiche de " +
                "renseignement n°" + id.ToString() + " ?", "Confirmation de Suppression !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    web.DeleteRenseignements(id);
                }

                ReloadData();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de renseignement !");
                return;
            }
        }

    }
}
