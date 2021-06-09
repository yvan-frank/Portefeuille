
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class ProjectManagement : Form
    {
        private readonly ProjectController projectController = new ProjectController();
        
        public ProjectManagement()
        {
            InitializeComponent();
        }

        private void Btnafficher_Click(object sender, EventArgs e)
        {
            switch (btnafficher.Text)
            {
                case @"Afficher les options avancées":
                    gunaShadowPanel2.Visible = true;
                    btnafficher.Text = @"Masquer";
                    break;
                case "Masquer":
                    gunaShadowPanel2.Visible = false;
                    btnafficher.Text = @"Afficher les options avancées";
                    break;
            }
        }

        private void ChartSet()
        {
            //cartesianChart1.Series = new SeriesCollection
            //{
            //    new LineSeries
            //    {
            //        Values = new ChartValues<ObservablePoint>
            //        {
            //            new ObservablePoint(0,10),
            //            new ObservablePoint(4,7),
            //            new ObservablePoint(5,3),
            //            new ObservablePoint(10,8)
            //        },
            //        PointGeometrySize = 15
            //    },
            //    new LineSeries
            //    {
            //        Values = new ChartValues<ObservablePoint>
            //        {
            //            new ObservablePoint(5,10),
            //            new ObservablePoint(3,7),
            //            new ObservablePoint(5,3),
            //            new ObservablePoint(10,0)
            //        },
            //        PointGeometrySize = 15
            //    }
            //};
        }
        private void Insert()
        {
            TimeSpan tss = dateFin.Value - dateDebut.Value;


            try
            {
                ProjectModel projectModel = new ProjectModel(GenerateNumberInView());

                //projectModel.NumberProject = txtProjectName.Text;
                projectModel.ProjectName = txtProjectName.Text;
                projectModel.Description = txtDescrip.Text;
                projectModel.ProjectType = cmbTypeProject.SelectedItem.ToString();
                projectModel.Category = cmbCate.SelectedItem.ToString();
                projectModel.DateDebut = dateDebut.Value;
                projectModel.DateFin = dateFin.Value;
                projectModel.FunctionName = cmdChef.SelectedIndex+1;
                projectModel.State = cmbEtat.SelectedIndex + 1;
                projectModel.Status = cmbStatut.SelectedIndex + 1;
                projectModel.Cost = int.Parse(txtCout.Text);
                projectModel.DonePercent = 0;
                //projectModel.EstimatedDate = decimal.Parse(tss.TotalDays.ToString("####"));

                if (!projectController.CheckData(projectModel))
                    MessageBox.Show(projectController.Insert(projectModel) > 0 ? "Insertion succesfull" : "Dommage", @"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show(@"Insertion impossible, un projet appartient deja a cet identifiant", @"Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Insert();
            lblProjectNumber.Invoke(new Action((() =>
            {
                lblProjectNumber.Text = GenerateNumberInView();
            })));
        }

        private string GenerateNumberInView()
        {
            try
            {
                string result = String.Empty;
                string num = projectController.GenerateNumber();
                var substring = num.Substring(0, 5);
                string str = projectController.GenerateNumber();
                string[] numbers = Regex.Split(str, @"\D+");
                foreach (string nbr in numbers)
                {
                    int number;
                    if (int.TryParse(nbr, out number))
                    {
                        number++;
                        result = substring + number;
                    }
                }

                return result;
            }
            catch
            {
                return "PROJ-1";
            }

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            LoadCombox();

            ChartSet();
        }

        private void LoadCombox()
        {
            foreach (ProjectModel model in projectController.GetAll())
            {

                cmbSelectProjet.AddItem(model.NumberProject);
                cmbSelectProjet.selectedIndex = 0;
            }

            foreach (StatusAndStateProjectModel model in projectController.GetState())
            {
                cmbEtat.Items.Add(model.InstitulateEtat);
            }

            foreach (StatusAndStateProjectModel model in projectController.GetStatus())
            {
                cmbStatut.Items.Add(model.LibelleStatus);
            }

            lblProjectNumber.Invoke(new Action((() =>
            {
                lblProjectNumber.Text = GenerateNumberInView();
            })));
        }

        private void TaskManage()
        {
            
        }
        #region Manage project

        private void GetDataProject()
        {
            solidGaugeProjet.From = 0;
            solidGaugeProjet.To = 100;
            solidGaugeJalon.Uses360Mode = true;
            solidGaugeJalon.From = 0;
            solidGaugeJalon.To = 100;
            solidGaugeTasks.Uses360Mode = true;
            solidGaugeTasks.From = 0;
            solidGaugeTasks.To = 100;


            ProjectPropertyController jController = new ProjectPropertyController();
            ProjectPropertyModel model = jController.GetModel(cmbSelectProjet.selectedValue);

            TaskController tcController = new TaskController(); ;
            if (cmbSelectProjet.selectedValue == model.NumberProject)
            {
                if (model.DateDebut != null) lblDateDebut.Text = model.DateDebut.Value.ToLongDateString();
                if (model.DateFin != null) lblDateFin.Text = model.DateFin.Value.ToLongDateString();
                lblNomChefProjet.Text = model.FunctionName;
                lblCout.Text = model.Cost.ToString();
                lblStatus.Text = model.Status;
                lblEtat.Text = model.State;
                solidGaugeProjet.Value = double.Parse(model.DonePercent.ToString());
                solidGaugeTasks.Value = tcController.CountTaskProject(cmbSelectProjet.selectedValue);
            }

        }

       

        private void CmbSelectProjet_onItemSelected(object sender, EventArgs e)
        {
            GetDataProject();
            GetChartByTaskInProject();
        }


        private void GetChartByTaskInProject()
        {
            TaskPropertyController tController = new TaskPropertyController();
             
            ArrayList status = new ArrayList();
            ArrayList nbr = new ArrayList();

            foreach (TaskPropertyModel model in tController.GetModel(cmbSelectProjet.selectedValue))
            {
                status.Add(model.Status);
                nbr.Add(model.TaskId);
            }

            if (status.Count > 0 || nbr.Count > 0)
            {
                chart1.Series[0].Points.DataBindXY(status, nbr);
            }
            else
            {
                chart1.Series[0].Points.Clear();
            }
            
        }


        #endregion
    }
}
