
using System.Collections.Generic;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void Btnafficher_Click(object sender, System.EventArgs e)
        {
            if (btnafficher.Text.Equals("Afficher les options avancées"))
            {
                gunaShadowPanel2.Visible = true;
                btnafficher.Text = "Masquer";
            }
            else if (btnafficher.Text.Equals("Masquer"))
            {
                gunaShadowPanel2.Visible = false;
                btnafficher.Text = "Afficher les options avancées";
            }
        }

    }
}
