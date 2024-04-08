using System;
using System.Windows.Forms;

namespace ChuKhaBanh_v3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cHuKhAbAnH_v3());
        }
    }
}
