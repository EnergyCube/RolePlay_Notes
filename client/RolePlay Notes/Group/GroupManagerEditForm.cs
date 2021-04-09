using RolePlay_Notes.Properties;
using System;
using System.Web.Security;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class GroupManagerEditForm : Form
    {
        private RPN_API_Web web;
        private string member_username;

        public GroupManagerEditForm(RPN_API_Web web, string member_username)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            groupManagerEditMemberFormSkin.FlatColor = Program.UIColor;

            permFlatComboBox.HoverColor = Program.UIColor;

            this.web = web;
            this.member_username = member_username;


            // User Load
            if (member_username != null)
            {
                usernameFlatTextBox.ReadOnly = true;
                applyFlatButton.Enabled = false;

                try
                {
                    RPN_API_Json.InternalData internalData = web.GetUser(member_username);

                    if (internalData.Username.Equals(member_username))
                    {
                        usernameFlatTextBox.Text = member_username;
                        renseignementIdNumericUpDown.Value = int.Parse(internalData.RenseignementID.ToString());
                        if (internalData.Permission.Equals("max"))
                        {
                            permFlatComboBox.Text = "Tous les Droits";
                        }
                        else if (internalData.Permission.Equals("med"))
                        {
                            permFlatComboBox.Text = "Droits Étendus";
                        }
                        else if (internalData.Permission.Equals("min"))
                        {
                            permFlatComboBox.Text = "Droits Limités";
                        }
                        passFlatTextBox.Text = "Bonjour :3 !";
                    }

                    applyFlatButton.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la récupérations des informations des membres du groupe !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }
            }
        }

        private void randomFlatButton_Click(object sender, EventArgs e)
        {
            passFlatTextBox.Text = Membership.GeneratePassword(new Random().Next(8, 12), new Random().Next(2, 6));
        }

        private void cancelFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            applyFlatButton.Enabled = false;
            usernameFlatTextBox.Text = usernameFlatTextBox.Text.ToLower();
            if (usernameFlatTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Le nom d'utilisateur ne doit pas comporter d'espace ou de charactères spéciaux !", "Erreur de formatage");
                applyFlatButton.Enabled = true;
                return;
            }
            else if (string.IsNullOrWhiteSpace(usernameFlatTextBox.Text))
            {
                MessageBox.Show("Le nom d'utilisateur n'est pas indiqué !", "Erreur de formatage");
                applyFlatButton.Enabled = true;
                return;
            }
            else if (permFlatComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez pas selectionné de permission !", "Erreur de formatage");
                applyFlatButton.Enabled = true;
                return;
            }
            else if (passFlatTextBox.Text.Length < 8 || string.IsNullOrEmpty(passFlatTextBox.Text)
              || string.IsNullOrWhiteSpace(passFlatTextBox.Text))
            {
                MessageBox.Show("Le mot de passe n'est pas indiqué ou fait moins de 8 charactères !", "Erreur de formatage");
                applyFlatButton.Enabled = true;
                return;
            }

            if (member_username == null)
            {
                RPN_API_Web.Permission permission = RPN_API_Web.Permission.Unknown;

                if (permFlatComboBox.Text.Equals("Tous les Droits"))
                {
                    permission = RPN_API_Web.Permission.Max;
                }
                else if (permFlatComboBox.Text.Equals("Droits Étendus"))
                {
                    permission = RPN_API_Web.Permission.Med;
                }
                else if (permFlatComboBox.Text.Equals("Droits Limités"))
                {
                    permission = RPN_API_Web.Permission.Min;
                }

                try
                {
                    if (web.CreateUser(usernameFlatTextBox.Text, passFlatTextBox.Text, (int)renseignementIdNumericUpDown.Value, permission))
                    {
                        if (MessageBox.Show("L'utilisateur " + usernameFlatTextBox.Text.ToLower() + " a été crée avec les permissions '" + permFlatComboBox.Text +
                            "' et le mot de passe : " + passFlatTextBox.Text + "\n\nVoulez vous copier les informations de connection dans le presse-papier ?",
                            "Création de " + usernameFlatTextBox.Text + " réussite !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Clipboard.SetText("Voici les identifiants pour te connecter à ton compte RPN !" +
                                "\n\nUtilisateur : " + usernameFlatTextBox.Text.ToLower() + "\nMot de passe : " + passFlatTextBox.Text + "\nGroupe : " + web.GetGroup());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'envoie du nouveau membre !", "Erreur");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'envoie du nouveau membre !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }
                Close();
            }
            else
            {
                string password = passFlatTextBox.Text.Equals("Bonjour :3 !") ? null : passFlatTextBox.Text;

                RPN_API_Web.Permission permission = RPN_API_Web.Permission.Unknown;

                if (permFlatComboBox.Text.Equals("Tous les Droits"))
                {
                    permission = RPN_API_Web.Permission.Max;
                }
                else if (permFlatComboBox.Text.Equals("Droits Étendus"))
                {
                    permission = RPN_API_Web.Permission.Med;
                }
                else if (permFlatComboBox.Text.Equals("Droits Limités"))
                {
                    permission = RPN_API_Web.Permission.Min;
                }

                try
                {
                    if (web.EditUser(usernameFlatTextBox.Text, password, (int)renseignementIdNumericUpDown.Value, permission))
                    {
                        if (password != null)
                        {
                            if (MessageBox.Show("L'utilisateur " + usernameFlatTextBox.Text.ToLower() + " a été mis à jour avec les permissions '" + permFlatComboBox.Text +
                                "' et le mot de passe : " + passFlatTextBox.Text + "\n\nVoulez vous copier les nouvelles informations de connection dans le presse-papier ?",
                                "Création de " + usernameFlatTextBox.Text + " réussite !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Clipboard.SetText("Voici les nouveaux identifiants pour te connecter à ton compte RPN !" +
                                    "\n\nUtilisateur : " + usernameFlatTextBox.Text.ToLower() + "\nMot de passe : " + passFlatTextBox.Text + "\nGroupe : " + web.GetGroup());
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("L'utilisateur " + usernameFlatTextBox.Text.ToLower() + " a été mis à jour avec les permissions '" + permFlatComboBox.Text +
                                "' (Le mot de passe n'a pas changé)\n\nVoulez vous copier les nouvelles informations de connection dans le presse-papier ?",
                                "Création de " + usernameFlatTextBox.Text + " réussite !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Clipboard.SetText("Voici les nouveaux identifiants pour te connecter à ton compte RPN !" +
                                    "\n\nUtilisateur : " + usernameFlatTextBox.Text.ToLower() + "\nMot de passe : Le même que votre précédant mot de passe \nGroupe : " + web.GetGroup());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue lors de l'envoie du nouveau membre !", "Erreur");
                    }
                    password = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'envoie du nouveau membre !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }
                Close();
            }
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flatMax1_Click(object sender, EventArgs e)
        {

        }
    }
}
