using System;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace iPorfolio.Views.Home
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            string[] x = { "Open", "InProgress", "Completed", "Onhold", "Cancel" };
            int[] y = { 30, 28, 25, 25, 0 };
            chart1.Series[0].ChartType = SeriesChartType.Bar;
            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Legends[0].Enabled = true;
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
