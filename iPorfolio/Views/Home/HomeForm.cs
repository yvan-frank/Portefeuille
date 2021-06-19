

using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;
using iPorfolio.Views.Evaluations;

namespace iPorfolio.Views.Home
{
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
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
        }

        private PanelScrollHelper panelScroll;
       
        private void BtnProjet_Click(object sender, System.EventArgs e)
        {
            btnScenario.Visible = false;
            btnCriteria.Visible = false;
            OnChildForm(new ProjectManagement());
        }

        private void BtnDashboard_Click(object sender, System.EventArgs e)
        {
            btnScenario.Visible = false;
            btnCriteria.Visible = false;
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
            CriteriaForm criteria = new CriteriaForm {ShowInTaskbar = false};
            criteria.ShowDialog();
        }

        private void PanContainer_Resize(object sender, System.EventArgs e)
        {
        }

        private void BtnExecutive_Click(object sender, System.EventArgs e)
        {
            OnChildForm(new ExecutiveDashboardForm());
        }
    }
}
