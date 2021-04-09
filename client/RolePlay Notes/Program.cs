using System;
using System.Drawing;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    static class Program
    {

        public static bool IsFullscreen = false;
        public static Color UIColor = Color.FromArgb(0, 128, 255); // Default Theme

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

    }
}
