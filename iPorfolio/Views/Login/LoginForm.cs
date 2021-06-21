using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

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
            var login = new UserController();

            MessageBox.Show(login.Login(TxtId.Text, TxtMdp.Text) ? "Ok" : "non ok");
        }
    }
}
