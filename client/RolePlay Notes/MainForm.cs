using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class MainForm : Form
    {
        private RPN_API_Web web;

        public MainForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            mainFormSkin.FlatColor = Program.UIColor;

            this.web = web;

            nameFlatLabel.Text = "Connecté à RPN en temps que '" + web.GetUsername() + "'";
            groupFlatLabel.Text = "Votre groupe est '" + web.GetGroup() + "'";
            versionFlatLabel.Text = "v" + ProductVersion;

            Reload();
        }

        private void UpdateScreenState()
        {
            if (WindowState == FormWindowState.Maximized)
                Program.IsFullscreen = true;
            else
                Program.IsFullscreen = false;
        }

        private void renseignementFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new RenseignementForm(web).ShowDialog();
            Reload();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsPictureBox_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new SettingsForm().ShowDialog();
            mainFormSkin.FlatColor = Program.UIColor;
            mainFormSkin.Refresh();
        }

        private void searchFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new SearchForm(web).ShowDialog();
            Reload();
        }
        private void groupManagerFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new GroupManagerForm(web).ShowDialog();
            Reload();
        }

        private void Reload()
        {
            groupManagerFlatButton.Enabled = false;

            LoadGroup();

            if (web.GetPermission(web.GetUsername()) >= RPN_API_Web.Permission.Med)
            {
                groupManagerFlatButton.Enabled = true;
            }

            int groupStockMoney = 0;
            foreach (RPN_API_Json.StorageData storageData in web.GetStorageData())
            {
                groupStockMoney += storageData.Quantity * web.GetRessourceTypeFromId(storageData.RessourceType).Price;
            }

            int groupMoney = 0;
            foreach (RPN_API_Json.MoneyData moneyData in web.GetAllMoney())
            {
                groupMoney += moneyData.MoneyGroup;
            }

            stockMoneyFlatLabel.Text = "Stock du Groupe : " + groupStockMoney.ToString("C0");
            groupMoneyFlatLabel.Text = "Argent du Groupe : " + groupMoney.ToString("C0");
        }

        private void LoadGroup()
        {
            groupListBox.Items.Clear();
            try
            {
                foreach (RPN_API_Json.InternalData internalData in web.GetAllUsers())
                {
                    groupListBox.Items.Add(internalData.Username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupérations des membres de groupe !\n" +
                    "Erreur : " + ex.Message, "Erreur");
                Close();
            }
        }

        private void stockFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new StorageForm(web).ShowDialog();
            Reload();
        }

        private void moneyFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new MoneyForm(web).ShowDialog();
            Reload();
        }

        private void relationFlatButton_Click(object sender, EventArgs e)
        {
            UpdateScreenState();
            new RelationForm(web).ShowDialog();
            Reload();
        }
    }
}
