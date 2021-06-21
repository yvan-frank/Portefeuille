
using System.Windows.Forms;
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

        private void ExecutiveDashboardForm_Load(object sender, System.EventArgs e)
        {
            panelScroll = new PanelScrollHelper(panContent, gunaVScrollBar1, true);
            panelScroll.UpdateScrollBar();
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
