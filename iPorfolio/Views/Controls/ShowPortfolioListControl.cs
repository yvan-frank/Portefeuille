using System;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Home;
using Models;

namespace iPorfolio.Views.Controls
{
    public partial class ShowPortfolioListControl : UserControl
    {
        public ShowPortfolioListControl()
        {
            InitializeComponent();
        }

        private void BtnVisualiser_Click(object sender, EventArgs e)
        {
            try
            {
                PortfolioController c = new PortfolioController();

                foreach (PortfolioModel model in c.GetAll())
                {
                    string[] id = new[] {model.IdPortfolio};

                    for (int i = 0; i < 1; i++)
                    {
                        var j = i;
                        btnVisualiser.Invoke(new Action((() =>
                        {
                            if (lblNump.Text.Equals(id[j]))
                            {
                               
                                HomeForm home = new HomeForm(lblNump.Text);
                                home.Show();
                            }
                        })));
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
