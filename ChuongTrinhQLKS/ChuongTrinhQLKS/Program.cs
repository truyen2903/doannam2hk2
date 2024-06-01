using System;
using System.Windows.Forms;

namespace ChuongTrinhQLKS
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Fdashboard());
        }
        public static class GlobalVariables
        {
            public static string LoggedInUsername;
        }
    }
}
