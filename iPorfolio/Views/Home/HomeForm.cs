

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

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private Form _activForm = null;
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
            OnChildForm(new DashboardForm());
        }

        private void BtnProjet_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new ProjectManagement());
        }

        private void BtnDashboard_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new DashboardForm());
        }

        private void BtnEvaluation_Click(object sender, System.EventArgs e)
        {
            panContainer.Controls.Clear();
            btnScenario.Visible = true;
            btnCriteria.Visible = true;
            panContainer.Controls.Add(btnScenario);
            panContainer.Controls.Add(btnCriteria);
        }

        private void BtnScenario_Click(object sender, System.EventArgs e)
        {
            ScenarioForm scenario = new ScenarioForm();
            scenario.ShowDialog();
            scenario.ShowInTaskbar = false;
        }

        private void BtnCriteria_Click(object sender, System.EventArgs e)
        {
            CriteriaForm criteria = new CriteriaForm();
            criteria.ShowInTaskbar = false;
            criteria.ShowDialog();
        }
    }
}
