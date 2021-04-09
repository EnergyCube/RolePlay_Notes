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

            if (!string.IsNullOrEmpty(iniFile.Read("user", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("password", "Login")) &&
                !string.IsNullOrEmpty(iniFile.Read("db", "Login")))
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
            web = new RPN_API_Web(userFlatTextBox.Text, mdpFlatTextBox.Text, groupFlatTextBox.Text);

            try
            {
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
