using System;
using System.Collections;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Controls;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class DashboardForm : Form
    {
        private ProjectController _project = new ProjectController();
        private TaskController _task = new TaskController();
      
        public string P { get; }
        public DashboardForm()
        {
            InitializeComponent();
        }
        public DashboardForm(string p)
        {
            InitializeComponent();
            this.P = p;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
           
            lblCountProject.Text = _project.CountProject(P).ToString();

            lblTotal.Text = @"FCFA "+_project.GetCostProject(P);
            lblTasks.Text = _task.GetALLTasks().ToString();

            LoadChart();
            LoadDataTable();

        }

        private void LoadChart()
        {
            ProjectPropertyController controller = new ProjectPropertyController();

            ArrayList status = new ArrayList();
            ArrayList nbr = new ArrayList();

            try
            {
                foreach (ProjectPropertyModel model in controller.GetModelList())
                {
                    status.Add(model.Status);
                    nbr.Add(model.ProjectByStatus);
                }
                chart2.Series[0].Points.DataBindXY(status, nbr);
                chart1.Series[0].Points.DataBindXY(status, nbr);
            }
            catch
            {
               //
            }
        }

        private void LoadDataTable()
        {
            var dataC = new Datacontrol();

            gunaLinePanel1.Controls.Add(dataC);
            ProjectPropertyController pcController = new ProjectPropertyController();

            foreach (ProjectPropertyModel mod in pcController.GetAll(P))
            {
                string[] chef1 = { mod.FunctionName };
                string[] numbe = { mod.NumberProject };
                string[] nom = { mod.ProjectName };
                string[] dateDebut = { mod.DateDebut.Value.ToShortDateString() };
                string[] datefin = {mod.DateFin.Value.ToLongDateString() };
                string[] avancement = { mod.DonePercent + " %" };
                string[] cout = { mod.Cost + " FCFA" };

                for (int i = 0; i < 1; i++)
                {
                    var con = new UserControl1();
                    con.Dock = DockStyle.Top;
                    con.lbChef.Text = chef1[i];
                    con.lbNom.Text = numbe[i];
                    con.lblNm.Text = nom[i];
                    con.lbDebut.Text = dateDebut[i];
                    con.lbDateCible.Text = @"Date cible " + datefin[i];
                    con.lbAvancement.Text = avancement[i];
                    con.lbCout.Text = cout[i];

                    pnList.Controls.Add(con);
                }
            }

        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
