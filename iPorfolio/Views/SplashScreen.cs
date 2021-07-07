using System;
using System.Windows.Forms;
using iPorfolio.Views.Home;
using iPorfolio.Views.Login;


namespace iPorfolio.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value += 1;
            }

            if (progressBar1.Value == 100)
            {
                guna2WinProgressIndicator1.AutoStart = false;
                //timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
                var login = new LoginForm();
                login.Show();
            }
        }
    }
}
