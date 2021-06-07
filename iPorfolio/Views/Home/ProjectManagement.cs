
using System;
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

        private void Insert()
        {
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

        #region Manage project

        private void CmbSelectProjet_onItemSelected(object sender, EventArgs e)
        {
            GetDataProject();
        }

        private void GetDataProject()
        {
            ProjectPropertyController jController = new ProjectPropertyController();
            ProjectPropertyModel model = jController.GetModel(cmbSelectProjet.selectedValue);
            if (cmbSelectProjet.selectedValue == model.NumberProject)
            {

                lblDateDebut.Text = model.DateDebut.ToString();
                lblDateFin.Text = model.DateFin.ToString();
                lblNomChefProjet.Text = model.FunctionName;
                lblCout.Text = model.Cost.ToString();
                lblStatus.Text = model.Status;
            }
        }

        #endregion

    }
}
