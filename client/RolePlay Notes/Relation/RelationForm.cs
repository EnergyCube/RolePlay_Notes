using RolePlay_Notes.Properties;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class RelationForm : Form
    {
        private RPN_API_Web web;

        public RelationForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            relationFormSkin.FlatColor = Program.UIColor;

            relationDataGridView.Columns.Add("id", "Id");
            relationDataGridView.Columns.Add("name", "Nom");
            relationDataGridView.Columns.Add("behaviour", "Comportement");
            relationDataGridView.Columns.Add("strength", "Puissance");
            relationDataGridView.Columns.Add("type", "Type");
            relationDataGridView.Columns.Add("financial_situation", "Situation Financière");
            relationDataGridView.Columns.Add("headcount", "Effectif");

            relationDataGridView.Columns[0].Visible = false;
            relationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            relationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            relationDataGridView.AllowUserToResizeRows = false;

            this.web = web;

            Reload();
        }

        private void Reload()
        {
            relationDataGridView.Rows.Clear();

            foreach (RPN_API_Json.RelationData relationData in web.GetAllRelations())
            {
                relationDataGridView.Rows.Add(relationData.Id, relationData.Name, relationData.Behaviour, relationData.Strength,
                    relationData.Type, relationData.FinancialSituation, relationData.Headcount);
            }

            relationDataGridView.Refresh();

        }

        private void addRelationFlatButton_Click(object sender, System.EventArgs e)
        {
            new RelationEditForm(web, -1).ShowDialog();
            Reload();
        }

        private void closeFlatLabel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void editRelationFlatButton_Click(object sender, System.EventArgs e)
        {
            if (relationDataGridView.SelectedRows.Count > 0)
            {
                int id = int.Parse(relationDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                new RelationEditForm(web, id).ShowDialog();
                Reload();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de relation !");
                return;
            }
        }

        private void relationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (relationDataGridView.SelectedCells.Count > 0)
            {
                int id = int.Parse(relationDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                new RelationEditForm(web, id).ShowDialog();
                Reload();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de relation !");
                return;
            }
        }

        private void refreshFlatButton_Click(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void deleteRelationFlatButton_Click(object sender, System.EventArgs e)
        {
            if (relationDataGridView.SelectedRows.Count > 0)
            {
                int id = int.Parse(relationDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                string name = relationDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer la relation '" + name + "' (ID " + id + ") ?",
                    "Supprimer une relation ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    web.DeleteRelation(id);
                    Reload();
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de relation !");
                return;
            }
        }
    }
}
