
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.Lib.ScrollBar;
using Guna.UI2.WinForms;

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

        private void BtnShowSide_Click(object sender, System.EventArgs e)
        {
            panside.Visible = true;
            panside.BringToFront();
        }

        private void MetroButton1_Click(object sender, System.EventArgs e)
        {
            panside.Visible = false;
        }
    }
}
