using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Home;

namespace iPorfolio.Views.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btnannul_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnconnect_Click(object sender, EventArgs e)
        {
            UserController user = new UserController();
            var login = user.Login(TxtId.Text, TxtMdp.Text);

            if (string.IsNullOrEmpty(TxtId.Text) && string.IsNullOrEmpty(TxtMdp.Text))
            {
                MsgError("Veuillez saisir tous les champs");
            }

            if (TxtId.Text != string.Empty && TxtMdp.Text != string.Empty)
            {
                if (login)
                {
                    var home = new HomeForm();
                    home.Show();
                    home.FormClosed += Deconnexion;
                    this.Hide();
                }
                else
                {
                    MsgError("Identifiant ou mot de passe incorrect. \n Veuillez réessayer");
                    TxtMdp.Clear();
                    TxtId.Clear();
                    TxtId.Focus();
                }
            }
            
        }

        private void MsgError(string message)
        {
            lblError.Visible = true;
            lblError.Text = " " + message;
        }

        private void Deconnexion(object sender, FormClosedEventArgs e)
        {
            TxtMdp.Clear();
            TxtId.Clear();
            lblError.Visible = false;
            this.Show();
        }
    }
}
