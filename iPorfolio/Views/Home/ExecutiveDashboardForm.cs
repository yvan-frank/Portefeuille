
using System.Windows.Forms;
using Controllers;
using Guna.UI.Lib.ScrollBar;

namespace iPorfolio.Views.Home
{
    public partial class ExecutiveDashboardForm : Form
    {
        private PanelScrollHelper panelScroll;

        public ExecutiveDashboardForm()
        {
            InitializeComponent();

        }

        private ProjectController c = new ProjectController();
        private TaskController t = new TaskController();
        private void ExecutiveDashboardForm_Load(object sender, System.EventArgs e)
        {
            panelScroll = new PanelScrollHelper(panContent, gunaVScrollBar1, true);
            panelScroll.UpdateScrollBar();

            lblProject.Text = c.CountProject("1").ToString();
            lblBudget.Text = c.GetCostProject("1").ToString();
            lblTask.Text = t.GetALLTasks().ToString();
        }

        private void PanContent_Resize(object sender, System.EventArgs e)
        {
            if (panelScroll != null)
                panelScroll.UpdateScrollBar();
        }

        private void Guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
