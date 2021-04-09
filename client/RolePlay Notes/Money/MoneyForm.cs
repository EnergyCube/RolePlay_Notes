using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class MoneyForm : Form
    {
        private RPN_API_Web web;

        public MoneyForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            moneyManagerFormSkin.FlatColor = Program.UIColor;

            moneyPersoDataGridView.Columns.Add("username", "Utilisateur");
            moneyPersoDataGridView.Columns.Add("playerid", "Renseignement ID");
            moneyPersoDataGridView.Columns.Add("money", "Argent");

            moneyGroupDataGridView.Columns.Add("username", "Utilisateur");
            moneyGroupDataGridView.Columns.Add("playerid", "Renseignement ID");
            moneyGroupDataGridView.Columns.Add("money", "Argent");


            moneyPersoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            moneyPersoDataGridView.AllowUserToResizeRows = false;
            moneyPersoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            moneyGroupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            moneyGroupDataGridView.AllowUserToResizeRows = false;
            moneyGroupDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.web = web;

            Reload();
        }

        void Reload()
        {
            moneyPersoDataGridView.Rows.Clear();
            moneyGroupDataGridView.Rows.Clear();
            foreach (RPN_API_Json.MoneyData moneyData in web.GetAllMoney())
            {
                moneyPersoDataGridView.Rows.Add(moneyData.Username, moneyData.RenseignementID, moneyData.MoneyPerso);
            }
            foreach (RPN_API_Json.MoneyData moneyData in web.GetAllMoney())
            {
                moneyGroupDataGridView.Rows.Add(moneyData.Username, moneyData.RenseignementID, moneyData.MoneyGroup);
            }
            moneyPersoDataGridView.Refresh();
            moneyGroupDataGridView.Refresh();
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshFlatButton_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void editMoneyFlatButton_Click(object sender, EventArgs e)
        {
            if (moneyPersoDataGridView.SelectedRows.Count > 0)
            {
                string user = moneyPersoDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                new MoneyEditForm(web, user, "perso").ShowDialog();
                Reload();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de membre !");
                return;
            }
        }

        private void editMoneyGroupFlatButton_Click(object sender, EventArgs e)
        {
            if (moneyGroupDataGridView.SelectedRows.Count > 0)
            {
                string user = moneyGroupDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                new MoneyEditForm(web, user, "group").ShowDialog();
                Reload();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de membre !");
                return;
            }
        }
    }
}
