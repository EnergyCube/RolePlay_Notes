using RolePlay_Notes.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net;
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
                if (string.IsNullOrEmpty(iniFile.Read("server", "Login")))
                    iniFile.Write("server", "", "Login");
                if (string.IsNullOrEmpty(iniFile.Read("ssl", "Login")))
                    iniFile.Write("ssl", "", "Login");
                MessageBox.Show("Vous semblez avoir lancé RPN sans avoir de fichier de configuration valide, ce fichier " +
                    "est très important et comporte les informations du serveur.\nMerci d'ouvrir le fichier config.ini " +
                    "qui se situe dans le dossier de l'application afin d'y rentrer les informations néecessaires !\n" +
                    "Vous devriez peut être réinstaller l'application afin de restaurer le fichier d'origine.",
                    "Fichier de Configuration Invalide");
                Environment.Exit(0);
            }

            if (iniFile.Read("ssl", "Login").Equals("true", StringComparison.InvariantCultureIgnoreCase))
            {
                if (string.IsNullOrEmpty(iniFile.Read("ssl_version", "Login")))
                {
                    // 768 TLS 1.1 - 3072 TLS 1.2 - 12288 TLS 1.3
                    if (Environment.OSVersion.Version.Major >= 10 /* Windows 10 */ ||
                        (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 3) /* Windows 8.1 */)
                    {
                            /* 1.3 not working :| */
                            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                            iniFile.Write("ssl_version", "1.2", "Login");
                    }
                    else
                    {
                        if (!iniFile.Read("no_ssl_warning", "Login").Equals("true", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MessageBox.Show("Votre version de Windows ne supporte pas le TLS 1.2 !\n" +
                               "La version TLS 1.0 sera utilisé à la place, merci de noter que cette version est " +
                               "considérée comme compromise." +
                               "\nSi vous pensez que votre ordinateur est en mesure d'utiliser " +
                               "une version plus récente, modifier la version TLS dans le fichier de configuration.\n" +
                               "(Merci de noter qu'il est probable que la connexion au serveur échoue, car la majorité des " +
                               "serveur désactive les communications TNS 1.0)", "Windows < 10 !");
                            iniFile.Write("deprecated_ssl_warning", "true", "Login");
                        }
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; // TLS 1.0
                        iniFile.Write("ssl_version", "1.0", "Login");
                    }
                } else
                {
                    string tls_version = iniFile.Read("ssl_version", "Login");
                    Console.WriteLine(tls_version);
                    if (tls_version.Equals("1.0", StringComparison.InvariantCultureIgnoreCase))
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; // TLS 1.0
                    else if (tls_version.Equals("1.1", StringComparison.InvariantCultureIgnoreCase))
                        ServicePointManager.SecurityProtocol = (SecurityProtocolType)768; // TLS 1.1
                    else if (tls_version.Equals("1.2", StringComparison.InvariantCultureIgnoreCase))
                        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.2
                    else if (tls_version.Equals("1.3", StringComparison.InvariantCultureIgnoreCase))
                        ServicePointManager.SecurityProtocol = (SecurityProtocolType)12288; // TLS 1.3
                    else
                    {
                        MessageBox.Show("Version TLS invalide ! Réinitialisation de la version...");
                        if (Environment.OSVersion.Version.Major >= 10 /* Windows 10 */ ||
                        (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 3) /* Windows 8.1 */)
                        {
                            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // TLS 1.3
                            iniFile.Write("ssl_version", "1.2", "Login");
                        }
                        else
                        {
                            if (!iniFile.Read("no_ssl_warning", "Login").Equals("true", StringComparison.InvariantCultureIgnoreCase))
                            {
                                MessageBox.Show("Votre version de Windows ne semble pas supporter le TLS 1.2 !\n" +
                                   "La version TLS 1.0 sera utilisé à la place, merci de noter que cette version est " +
                                   "considérée comme compromise." +
                                   "\nSi vous pensez que votre ordinateur est en mesure d'utiliser " +
                                   "une version plus récente, modifier la version TLS dans le fichier de configuration.\n" +
                                   "(Merci de noter qu'il est probable que la connexion au serveur échoue, car la majorité des " +
                                   "serveur ont désactivé les communications TLS 1.0)", "Windows < 10 !");
                                iniFile.Write("deprecated_ssl_warning", "true", "Login");
                            }
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; // TLS 1.0
                            iniFile.Write("ssl_version", "1.0", "Login");
                        }
                    }

                }
                RPN_API_Web.BaseURL = "https://" + iniFile.Read("server", "Login") + "/";
            }
            else
            {
                if (!iniFile.Read("no_ssl_warning", "Login").Equals("true", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("La connection utilisé par RPN n'est pas sécurisée et est donc soumise à de potentiels " +
                        "attaques, merci d'éviter la transmission de donnée sensible et d'uniquement vous connecter depuis " +
                        "des lieux de confiances.\nAfin de rendre votre connection sécurisée, contactez l'administrateur du " +
                        "serveur RPN et demandez lui d'activer le TLS/SSL. Si ce dernier le supporte déjà, remplacez la ligne " +
                        "ssl=false avec ssl=true dans le fichier config.ini du dossier d'installation de RPN.\n\n" +
                        "Vous ne verrez plus ce message...", "Connection Sans SSL/TLS !");
                    iniFile.Write("no_ssl_warning", "true", "Login");
                }
                RPN_API_Web.BaseURL = "http://" + iniFile.Read("server", "Login") + "/";
            }

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
