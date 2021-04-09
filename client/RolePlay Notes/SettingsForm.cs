using RolePlay_Notes.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            settingsFormSkin.FlatColor = Program.UIColor;
        }


        private void selectedColorFlatButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                settingsFormSkin.FlatColor = colorDlg.Color;
                settingsFormSkin.Refresh();
            }
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            if (settingsFormSkin.FlatColor != Program.UIColor)
            {
                Program.UIColor = settingsFormSkin.FlatColor;
                IniFile iniFile = new IniFile("./config.ini");
                iniFile.Write("FlatColor", Program.UIColor.R + ";" + Program.UIColor.G + ";" + Program.UIColor.B, "UI");
            }

            Close();
        }

        private void cancelFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
