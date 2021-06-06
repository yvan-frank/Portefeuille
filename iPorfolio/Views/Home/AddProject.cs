
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class AddProject : Form
    {
        private readonly ProjectController projectController = new ProjectController();
        
        public AddProject()
        {
            InitializeComponent();
        }

        private void Btnafficher_Click(object sender, EventArgs e)
        {
            if (btnafficher.Text.Equals(@"Afficher les options avancées"))
            {
                gunaShadowPanel2.Visible = true;
                btnafficher.Text = @"Masquer";
            }
            else if (btnafficher.Text.Equals("Masquer"))
            {
                gunaShadowPanel2.Visible = false;
                btnafficher.Text = @"Afficher les options avancées";
            }
        }

        private void Insert()
        {
            try
            {
                ProjectModel projectModel = new ProjectModel(GenerateNumber());

                //projectModel.NumberProject = txtProjectName.Text;
                projectModel.ProjectName = txtProjectName.Text;
                projectModel.Description = txtDescrip.Text;
                projectModel.ProjectType = cmbTypeProject.SelectedItem.ToString();
                projectModel.Category = cmbCate.SelectedItem.ToString();
                projectModel.DateDebut = dateDebut.Value;
                projectModel.DateFin = dateFin.Value;
                projectModel.ChefProject = cmdChef.SelectedItem.ToString();
                projectModel.State = cmbEtat.SelectedIndex + 1;
                projectModel.Status = cmbStatut.SelectedIndex + 1;

                if (!projectController.CheckData(projectModel))
                
                    MessageBox.Show(projectController.Insert(projectModel) > 0 ? "Insertion succesfull" : "Dommage");
                else
                    MessageBox.Show(@"Insertion impossible, un projet appartient deja a cet identifiant");
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
                lblProjectNumber.Text = GenerateNumber();
            })));
        }

        private string GenerateNumber()
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

        private void AddProject_Load(object sender, EventArgs e)
        {
            foreach (ProjectModel model in projectController.GetAll())
            {
                //cmbSelectProjet.selectedIndex = 0;
                cmbSelectProjet.AddItem(model.NumberProject);
            }

            foreach (StatusAndStateProjectModel model in projectController.GetState())
            {
                cmbEtat.Items.Add(model.InstitulateEtat);
            }

            foreach (StatusAndStateProjectModel model in projectController.GetStatus())
            {
                cmbStatut.Items.Add(model.LibelleStatus);
            }

        }
    }
}
