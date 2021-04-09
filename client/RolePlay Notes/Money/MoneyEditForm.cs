using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class MoneyEditForm : Form
    {
        private RPN_API_Web web;
        private string username;
        private string type;

        public MoneyEditForm(RPN_API_Web web, string username, string type)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            moneyEditFormSkin.FlatColor = Program.UIColor;

            this.web = web;
            this.username = username;
            this.type = type;

            if (!string.IsNullOrWhiteSpace(username))
            {
                try
                {
                    RPN_API_Json.MoneyData money = web.GetMoney(username);
                    nameFlatTextBox.Text = money.Username;
                    if (type.Equals("perso", StringComparison.InvariantCultureIgnoreCase))
                    {
                        moneyNumericUpDown.Value = (int)money.MoneyPerso;
                    }
                    else if (type.Equals("group", StringComparison.InvariantCultureIgnoreCase))
                    {
                        moneyNumericUpDown.Value = (int)money.MoneyGroup;
                    }
                    else
                    {
                        throw new Exception("Money Type Invalid !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors du chargement de l'argent du membre !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Il est impossible de changer l'argent d'une personne qui n'exsite pas !", "Ne devrait pas survenir !");
            }

        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                try
                {
                    if (type.Equals("perso", StringComparison.InvariantCultureIgnoreCase)
                        || type.Equals("group", StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!web.EditMoney(username, (int)moneyNumericUpDown.Value, type))
                        {
                            MessageBox.Show("Impossible de modifier l'argent de l'utilisateur !", "Erreur");
                        }
                    }
                    else
                    {
                        throw new Exception("Money Type Invalid !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la modification d'argent !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }
            }
            Close();
        }
    }
}
