using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Controls;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class ProjectManagement : Form
    {
        private readonly ProjectController _projectController = new ProjectController();

        public string P { get; }
        public ProjectManagement()
        {
            InitializeComponent();
        }
        public ProjectManagement(string p)
        {
            InitializeComponent();
            this.P = p;
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
            //TimeSpan tss = dateFin.Value - dateDebut.Value;


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

                if (!_projectController.CheckData(projectModel))
                    MessageBox.Show(_projectController.Insert(projectModel) > 0 ? "Insertion succesfull" : "Dommage", @"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                string num = _projectController.GenerateNumber();
                var substring = num.Substring(0, 5);
                string str = _projectController.GenerateNumber();

                // extraction dans une chaine de tab en entree aux positions definies par un modele d expression reguliere
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

            DataTableControl();
        }


        private void LoadCombox()
        {
            foreach (ProjectModel model in _projectController.GetAll(int.Parse(P)))
            {

                cmbSelectProjet.AddItem(model.NumberProject);
                cmbSelectProjet.selectedIndex = 0;
            }

            foreach (StatusAndStateProjectModel model in _projectController.GetState())
            {
                cmbEtat.Items.Add(model.InstitulateEtat);
            }

            foreach (StatusAndStateProjectModel model in _projectController.GetStatus())
            {
                cmbStatut.Items.Add(model.LibelleStatus);
            }

            UserController user = new UserController();
            foreach (UserModel model4 in user.GetList())
            {
                cmdChef.Items.Add(model4.PM);
            }

            lblProjectNumber.Invoke(new Action((() =>
            {
                lblProjectNumber.Text = GenerateNumberInView();
            })));
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
            EvaluationController ev = new EvaluationController();
            ProjectPropertyModel model = jController.GetModel(cmbSelectProjet.selectedValue, P);
            EvaluationModel evaluationModel = ev.GetModelEvaluation(cmbSelectProjet.selectedValue);

            TaskController tcController = new TaskController();
            if (cmbSelectProjet.selectedValue == model.NumberProject)
            {
                if (model.DateDebut != null) lblDateDebut.Text = model.DateDebut.Value.ToLongDateString();
                if (model.DateFin != null) lblDateFin.Text = model.DateFin.Value.ToLongDateString();
                lblNomChefProjet.Text = model.FunctionName;
                lblCout.Text = model.Cost.ToString();
                lblBalance.Text = model.Cost.ToString();
                lblStatus.Text = model.Status;
                lblEtat.Text = model.State;
                solidGaugeProjet.Value = double.Parse(model.DonePercent.ToString());
                solidGaugeTasks.Value = tcController.CountTaskProject(cmbSelectProjet.selectedValue);




                try
                {
                    if (cmbSelectProjet.selectedValue == evaluationModel.ProjectNumber)
                    {
                        lblStatuproject.Text = @"PROJET EVALUE";
                        btnEval.Visible = false;
                    }
                    else
                    {
                        lblStatuproject.Text = @"PROJET NON EVALUE";
                        btnEval.Visible = true;
                    }
                }
                catch
                {
                    lblStatuproject.Text = @"PROJET NON EVALUE";
                    btnEval.Visible = true;
                }


                //Modifier data form
                UserController user = new UserController();
                foreach (StatusAndStateProjectModel model1 in _projectController.GetState())
                {
                    gunaComboBox4.Items.Add(model1.InstitulateEtat);
                }

                foreach (StatusAndStateProjectModel model2 in _projectController.GetStatus())
                {
                    gunaComboBox3.Items.Add(model2.LibelleStatus); 
                }

                foreach (UserModel model4 in user.GetList())
                {
                    gunaComboBox5.Items.Add(model4.PM);
                }

                gunaLineTextBox2.Text = model.ProjectName;
                gunaLineTextBox1.Text = model.Description;
                gunaDateTimePicker1.Text = model.DateDebut.ToString();
                gunaDateTimePicker2.Text = model.DateFin.ToString();
                gunaLineTextBox3.Text = model.Cost.ToString();
                gunaComboBox5.SelectedItem = model.FunctionName;
                gunaComboBox4.SelectedItem = model.State;
                gunaComboBox3.SelectedItem = model.Status;
                guna2ComboBox1.SelectedItem = model.Type;
                gunaComboBox1.SelectedItem = model.Category;

            }

        }

        private void Updating()
        {
            try
            {
                ProjectModel pUpdate = _projectController.GetModel(cmbSelectProjet.selectedValue, "1");

                pUpdate.ProjectName = gunaLineTextBox2.Text;
                pUpdate.Description = gunaLineTextBox1.Text;
                pUpdate.ProjectType = guna2ComboBox1.SelectedItem.ToString();
                pUpdate.Category = gunaComboBox1.SelectedItem.ToString();
                pUpdate.DateDebut = gunaDateTimePicker1.Value;
                pUpdate.DateFin = gunaDateTimePicker2.Value;
                pUpdate.FunctionName = gunaComboBox5.SelectedIndex + 1;
                pUpdate.State = gunaComboBox4.SelectedIndex + 1;
                pUpdate.Status = gunaComboBox3.SelectedIndex + 1;
                pUpdate.Cost = int.Parse(gunaLineTextBox3.Text);
                //projectModel.DonePercent = 0;

                if (_projectController.Update(pUpdate) > 0)
                {
                    MessageBox.Show(@"Ok");
                }
                else
                {
                    MessageBox.Show(@"Non ok");
                }
            }
            catch
            {
               //
            }
        }

        #region chargement des donnees du projet pour suppression

        private void DataTableControl()
        {
            foreach (ProjectModel model in _projectController.GetAll(int.Parse(P)))
            {
                string[] number = new[] {model.NumberProject};
                string[] infos = new[] {model.ProjectName};
                

                for (int i = 0; i < 1; i++)
                {
                    var delete = new DeleteControl();
                    delete.Dock = DockStyle.Top;

                    delete.lblNum.Text = number[i];
                    delete.lbInfos.Text = infos[i];
                    pnList.Controls.Add(delete);
                }
            }
        }
        #endregion


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

        private void BtnMaj_Click(object sender, EventArgs e)
        {
            Updating();
        }
    }
}
