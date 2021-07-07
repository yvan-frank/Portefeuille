using System;
using System.Windows.Forms;
using iPorfolio.Views;
using iPorfolio.Views.Home;
using iPorfolio.Views.Login;

namespace iPorfolio
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PortfolioForm());
        }
    }
}
