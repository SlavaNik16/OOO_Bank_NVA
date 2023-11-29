using OOO_Bank_NVA.Forms;
using System;
using System.Windows.Forms;

namespace OOO_Bank_NVA
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());//new AuthorizationForm());
        }
    }
}
