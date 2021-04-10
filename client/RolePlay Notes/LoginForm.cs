using RolePlay_Notes.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class LoginForm : Form
    {

        private IniFile iniFile;
        private RPN_API_Web web;

        public LoginForm()
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (!File.Exists("./config.ini"))
                File.Create("./config.ini").Close();

            iniFile = new IniFile("./config.ini");

            if (string.IsNullOrEmpty(iniFile.Read("server", "Login")) ||
                string.IsNullOrEmpty(iniFile.Read("ssl", "Login")))
            {
                iniFile.Write("ssl", "", "Login");
                iniFile.Write("server", "", "Login");
                MessageBox.Show("Vous semblez avoir lancé RPN sans avoir de fichier de configuration valide, ce fichier" +
                    "est très important et comporte les informations du serveur.\nMerci d'ouvrir le fichier config.ini" +
                    "qui se situe dans le dossier de l'application afin d'y rentrer les informations néecessaire !\n" +
                    "Vous devriez peut être réinstaller l'application afin de restauré le fichier d'origine.",
                    "Fichier de Configuration Invalide");
                Environment.Exit(0);
            }

            if (iniFile.Read("ssl", "Login").Equals("true", StringComparison.InvariantCultureIgnoreCase))
                RPN_API_Web.BaseURL = "https://" + iniFile.Read("server", "Login") + "/";
            else
                RPN_API_Web.BaseURL = "http://" + iniFile.Read("server", "Login") + "/";

            if (!string.IsNullOrEmpty(iniFile.Read("user", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("password", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("db", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("server", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("ssl", "Login")))
            {
                userFlatTextBox.Text = iniFile.Read("user", "Login");
                mdpFlatTextBox.Text = Base64Decode(iniFile.Read("password", "Login"));
                groupFlatTextBox.Text = iniFile.Read("db", "Login");
                remeberFlatCheckBox.Checked = true;
            }

            if (!string.IsNullOrEmpty(iniFile.Read("FlatColor", "UI")))
            {
                string[] colors = iniFile.Read("FlatColor", "UI").Split(';');
                Program.UIColor = Color.FromArgb(
                    int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]));
            }
            else
            {
                iniFile.Write("FlatColor", Program.UIColor.R + ";" + Program.UIColor.G + ";" + Program.UIColor.B, "UI");
            }

            loginFormSkin.FlatColor = Program.UIColor;

        }

        private void loginFlatButton_Click(object sender, EventArgs e)
        {
            loginFlatButton.Enabled = false;

            try
            {
                web = new RPN_API_Web(userFlatTextBox.Text, mdpFlatTextBox.Text, groupFlatTextBox.Text);
                if (web.Login())
                {
                    if (remeberFlatCheckBox.Checked)
                    {
                        iniFile.Write("user", userFlatTextBox.Text, "Login");
                        iniFile.Write("password", Base64Encode(mdpFlatTextBox.Text), "Login");
                        iniFile.Write("db", groupFlatTextBox.Text, "Login");
                    }
                    else
                    {
                        iniFile.DeleteSection("Login");
                    }

                    if (WindowState == FormWindowState.Maximized)
                        Program.IsFullscreen = true;
                    else
                        Program.IsFullscreen = false;

                    new MainForm(web).Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Merci de vérifiez les informations de connections !", "Identification");
                    loginFlatButton.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Impossible de se connecter à l'API de RPN !\n" + ex.Message, "Erreur !");
                loginFlatButton.Enabled = true;
            }

        }

        private void adminFlatButton_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        public static string Base64Encode(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
