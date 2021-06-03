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

        private void DashboardForm_Load(object sender, System.EventArgs e)
        {
            string[] x = {"Orange", "MTN", "Camtel", "Nexttel", "Yoomee"};
            int[] y = {30,28,25,25,22};
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(x,y);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
