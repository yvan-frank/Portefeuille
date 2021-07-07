using System.Windows.Forms;
using iPorfolio.Views.Evaluations;

namespace iPorfolio.Views.Home
{
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        public string Id { get; set; }
        public HomeForm(string id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private Form _activForm;
        private void OnChildForm(Form childForm)
        {
            if (_activForm != null)
            {
                _activForm.Close();
            }

            _activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panContainer.Controls.Add(childForm);
            panContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            OnChildForm(new DashboardForm(Id));
            lblPortefeuille.Text = @"Portefeuille N° "+ Id;
        }

        private void BtnProjet_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new ProjectManagement(Id));
        }

        private void BtnDashboard_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new DashboardForm(Id));
        }

        private void BtnEvaluation_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new EvaluationDashboard(Id));
        }

        private void PanContainer_Resize(object sender, System.EventArgs e)
        {
        }

        private void BtnExecutive_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new ExecutiveDashboardForm());
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Btndeconnexion_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(@"Vous êtes sur le point de vous déconnecter, êtes-vous sûr?", @"Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void BtnRetour_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
