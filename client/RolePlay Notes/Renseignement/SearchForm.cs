using RolePlay_Notes.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class SearchForm : Form
    {
        private RPN_API_Web web;

        public SearchForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            this.web = web;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            searchFormSkin.FlatColor = Program.UIColor;

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
        }

        private void closeFlatLabel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void searchFlatButton_Click(object sender, System.EventArgs e)
        {
            searchFlatButton.Enabled = false;
            editFlatButton.Enabled = false;
            deleteFlatButton.Enabled = false;
            renseignementDataGridView.Rows.Clear();
            renseignementDataGridView.Enabled = false;
            renseignementDataGridView.Refresh();

            rowNbFlatLabel.Text = "Recherche de fiches de renseignements correspondantes...";

            List<RPN_API_Json.RenseignementData> data = null;

            try
            {
                string financialSituationData = financialSituationFlatComboBox.Text.Equals("N/A") ? null : financialSituationFlatComboBox.Text;
                string behaviourData = behaviourComboBox.Text.Equals("N/A") ? null : behaviourComboBox.Text;

                string deadData = advancedSearchCheckBox.Checked ? deadFlatCheckBox.Checked.ToString() : null;
                string wantedData = advancedSearchCheckBox.Checked ? wantedFlatCheckBox.Checked.ToString() : null;

                DateTime dateTimeDate = dateLastEditFilterFlatToggle.Checked ? DateTime.Now.AddMonths(-(int)dateLastEditMinFlatNumeric.Value) : DateTime.MinValue;

                data = web.SearchRenseignement(nicknameFlatTextBox.Text, nameFlatTextBox.Text, pseudoFlatTextBox.Text, telFlatTextBox.Text,
                    affiliationFlatTextBox.Text, affiliationOldFlatTextBox.Text, positionFlatTextBox.Text, licensePlateFlatTextBox.Text,
                    knownVehicleFlatTextBox.Text, financialSituationData, behaviourData, deadData,
                    wantedData, nicknameFakeFlatTextBox.Text, nameFakeFlatTextBox.Text, dateTimeDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupérations des renseignements !\n" +
                    "Error : " + ex.Message);
                Close();
            }

            if (data != null)
            {
                foreach (RPN_API_Json.RenseignementData rensData in data)
                {
                    renseignementDataGridView.Rows.Add(rensData.Id, rensData.Nickname, rensData.Name,
                        rensData.Pseudo, rensData.Tel, rensData.Affiliation, rensData.FinancialSituation,
                        rensData.Behaviour, rensData.Dead, rensData.Wanted,
                        rensData.FakeNickname, rensData.FakeName); ;
                }
                rowNbFlatLabel.Text = data.Count.ToString() + " fiches de renseignements correspondantes !";
            }
            else
            {
                rowNbFlatLabel.Text = "Aucun Résultat !";
            }


            renseignementDataGridView.PerformLayout();
            renseignementDataGridView.Enabled = true;
            renseignementDataGridView.Refresh();
            searchFlatButton.Enabled = true;
            editFlatButton.Enabled = true;
            deleteFlatButton.Enabled = true;

        }

        private void renseignementDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new RenseignementEditForm(web,
                int.Parse(renseignementDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).ShowDialog();
        }

        private void editFlatButton_Click(object sender, EventArgs e)
        {
            if (renseignementDataGridView.SelectedRows.Count > 0)
            {
                new RenseignementEditForm(web,
                    int.Parse(renseignementDataGridView.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
            }
            else if (renseignementDataGridView.SelectedCells.Count > 0)
            {
                new RenseignementEditForm(web,
                    int.Parse(renseignementDataGridView.Rows[renseignementDataGridView.SelectedCells[0].RowIndex]
                        .Cells[0].Value.ToString())).ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de renseignement !");

            }
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
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de renseignement !");
                return;
            }
        }
    }
}
