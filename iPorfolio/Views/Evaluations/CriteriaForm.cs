using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Evaluations
{
    public partial class CriteriaForm : Form
    {
        ProjectController cp = new ProjectController();
        public string P { get; }
        #region Variables ponderations

        // les quotients de ponderation
        private const int CoherenceDegreeWithTheMission = 1;
        private const int AlignmentWithTheEnterpriseStrategy = 3;
        private const int UrgencyProjectDegree = 3;
        private const int ObjectiveProjectStability = 1;
        private const int SoutienDesPartiesPrenantes = 1;
        private const int DureeDuProjet = 3;
        private const int CoutduProjet = 3;
        private const int DisponibilteDesRessources = 2;
        private const int DegreeDeRiskDuringSonExecution = 2;
        private const int DegreeDeComplxiteDuProjet = 2;
        private const int CaractereInnovation = 1;
        private const int SkillsDevelop = 2;

        // les reponses au critere
        private const int A = -2;//tres faible
        private const int B = -1;//faible
        private const int C = 0;//neutre, moyen
        private const int D = 1;// tres fort
        private const int E = 2;//tres tres fort

        #endregion

        public CriteriaForm()
        {
            InitializeComponent();
        }
        public CriteriaForm(string p)
        {
            InitializeComponent();
            this.P = p;
        }

        private void CriteriaForm_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            guna2ShadowForm1.ShadowColor = Color.Blue;

            CriteriaController criteria = new CriteriaController();


            foreach (CriteriaModel model in criteria.GetAll())
            {
                try
                {
                    cmbCoMission.Items.Add(model.CoherenceDegreeWithTheMission);
                    cmbStrategy.Items.Add(model.AlignmentWithTheEnterpriseStrategy);
                    cmbUrgence.Items.Add(model.UrgencyProjectDegree);
                    cmbCout.Items.Add(model.CoutduProjet);
                    cmbComplex.Items.Add(model.DegreeDeComplxiteDuProjet);
                    cmbDuree.Items.Add(model.DureeDuProjet);
                    cmbInnovant.Items.Add(model.CaractereInnovation);
                    cmbSoutien.Items.Add(model.SoutienDesPartiesPrenantes);
                    cmbSkills.Items.Add(model.SkillsDevelopment);
                    cmbStable.Items.Add(model.ObjectiveProjectStability);
                    cmbressource.Items.Add(model.DisponibilteDesRessources);
                    cmdRisk.Items.Add(model.DegreeDeRiskDuringSonExecution);
                }
                catch 
                {
                    MessageBox.Show(@"Waiting for connection...");
                }
            }

            Loadproject();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loadproject()
        {
            foreach (ProjectModel model in cp.GetAll(int.Parse(P)))
            {
                cmbP.Items.Add(model.NumberProject);
            }
        }

        
        #region combobox

        private void Resultat()
        {
            result = _coefMission + strategy + urgency + stable + soutien + duree + cout + resource + risk + complex +
                     innovant + skills;
        }

        int result;
        int _coefMission;
        int strategy;
        int urgency;
        int stable;
        int soutien;
        int duree;
        int cout;
        int resource;
        int risk;
        int complex;
        int innovant;
        int skills;

        private void Insert()
        {
            EvaluationModel model = new EvaluationModel();
            EvaluationController controller = new EvaluationController();
            model.Score = result;

            try
            {
                if (model.ProjectNumber == null)
                {
                    //
                }

                model.ProjectNumber = cmbP.SelectedItem.ToString();
                model.CoherenceDegreeWithTheMission = _coefMission;
                model.AlignmentWithTheEnterpriseStrategy = strategy;
                model.UrgencyProjectDegree = urgency;
                model.ObjectiveProjectStability = stable;
                model.SoutienDesPartiesPrenantes = soutien;
                model.DureeDuProjet = duree;
                model.CoutduProjet = cout;
                model.DisponibilteDesRessources = resource;
                model.DegreeDeRiskDuringSonExecution = risk;
                model.DegreeDeComplxiteDuProjet = complex;
                model.CaractereInnovation = innovant;
                model.SkillsDevelop = skills;

                if (model.ProjectNumber != null)
                {
                    if (controller.Insert(model) > 0)
                    {
                        MessageBox.Show(@"EVALUATION TERMINEE", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(@"Insertion error");
                }
            }
            catch
            {
                MessageBox.Show(@"Veuillez choisir un projet", @"Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void CmbCoMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCoMission.SelectedIndex)
            {
                case 0:
                    _coefMission = A * CoherenceDegreeWithTheMission;
                    break;
                case 1:
                    _coefMission = B * CoherenceDegreeWithTheMission;
                    break;
                case 2:
                    _coefMission = C * CoherenceDegreeWithTheMission;
                    break;
                case 3:
                    _coefMission = D * CoherenceDegreeWithTheMission;
                    break;
                case 4:
                    _coefMission = E * CoherenceDegreeWithTheMission;
                    break;
            }

            guna2Chip1.Visible = true;
            guna2Chip1.Text = _coefMission.ToString();
            Resultat();
        }

        private void CmbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStrategy.SelectedIndex)
            {
                case 0:
                    strategy = A * AlignmentWithTheEnterpriseStrategy;
                    break;
                case 1:
                    strategy = B * AlignmentWithTheEnterpriseStrategy;
                    break;
                case 2:
                    strategy = C * AlignmentWithTheEnterpriseStrategy;
                    break;
                case 3:
                    strategy = D * AlignmentWithTheEnterpriseStrategy;
                    break;
                case 4:
                    strategy = E * AlignmentWithTheEnterpriseStrategy;
                    break;
            }

            guna2Chip11.Visible = true;
            guna2Chip11.Text = strategy.ToString();
            Resultat();
        }

        private void CmbUrgence_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbUrgence.SelectedIndex)
            {
                case 0:
                    urgency = A * UrgencyProjectDegree;
                    break;
                case 1:
                    urgency = B * UrgencyProjectDegree;
                    break;
                case 2:
                    urgency = C * UrgencyProjectDegree;
                    break;
                case 3:
                    urgency = D * UrgencyProjectDegree;
                    break;
                case 4:
                    urgency = E * UrgencyProjectDegree;
                    break;
            }

            guna2Chip4.Visible = true;
            guna2Chip4.Text = urgency.ToString();
            Resultat();
        }

        private void CmbStable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbStable.SelectedIndex)
            {
                case 0:
                    stable = A * ObjectiveProjectStability;
                    break;
                case 1:
                    stable = B * ObjectiveProjectStability;
                    break;
                case 2:
                    stable = C * ObjectiveProjectStability;
                    break;
                case 3:
                    stable = D * ObjectiveProjectStability;
                    break;
                case 4:
                    stable = E * ObjectiveProjectStability;
                    break;
            }

            guna2Chip10.Visible = true;
            guna2Chip10.Text = stable.ToString();
            Resultat();
        }

        private void CmbSoutien_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSoutien.SelectedIndex)
            {
                case 0:
                    soutien = A * SoutienDesPartiesPrenantes;
                    break;
                case 1:
                    soutien = B * SoutienDesPartiesPrenantes;
                    break;
                case 2:
                    soutien = C * SoutienDesPartiesPrenantes;
                    break;
                case 3:
                    soutien = D * SoutienDesPartiesPrenantes;
                    break;
                case 4:
                    soutien = E * SoutienDesPartiesPrenantes;
                    break;
            }

            guna2Chip9.Visible = true;
            guna2Chip9.Text = soutien.ToString();
            Resultat();
        }

        private void CmbDuree_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDuree.SelectedIndex)
            {
                case 0:
                    duree = A * DureeDuProjet;
                    break;
                case 1:
                    duree = B * DureeDuProjet;
                    break;
                case 2:
                    duree = C * DureeDuProjet;
                    break;
                case 3:
                    duree = D * DureeDuProjet;
                    break;
                case 4:
                    duree = E * DureeDuProjet;
                    break;
            }

            guna2Chip3.Visible = true;
            guna2Chip3.Text = duree.ToString();
            Resultat();
        }

        private void CmbCout_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCout.SelectedIndex)
            {
                case 0:
                    cout = A * CoutduProjet;
                    break;
                case 1:
                    cout = B * CoutduProjet;
                    break;
                case 2:
                    cout = C * CoutduProjet;
                    break;
                case 3:
                    cout = D * CoutduProjet;
                    break;
                case 4:
                    cout = E * CoutduProjet;
                    break;
            }

            guna2Chip8.Visible = true;
            guna2Chip8.Text = cout.ToString();
            Resultat();
        }

        private void Cmbressource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbressource.SelectedIndex)
            {
                case 0:
                    resource = A * DisponibilteDesRessources;
                    break;
                case 1:
                    resource = B * DisponibilteDesRessources;
                    break;
                case 2:
                    resource = C * DisponibilteDesRessources;
                    break;
                case 3:
                    resource = D * DisponibilteDesRessources;
                    break;
                case 4:
                    resource = E * DisponibilteDesRessources;
                    break;
            }

            guna2Chip7.Visible = true;
            guna2Chip7.Text = resource.ToString();
            Resultat();
        }

        private void CmdRisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmdRisk.SelectedIndex)
            {
                case 0:
                    risk = A * DegreeDeRiskDuringSonExecution;
                    break;
                case 1:
                    risk = B * DegreeDeRiskDuringSonExecution;
                    break;
                case 2:
                    risk = C * DegreeDeRiskDuringSonExecution;
                    break;
                case 3:
                    risk = D * DegreeDeRiskDuringSonExecution;
                    break;
                case 4:
                    risk = E * DegreeDeRiskDuringSonExecution;
                    break;
            }

            guna2Chip12.Visible = true;
            guna2Chip12.Text = risk.ToString();
            Resultat();
        }

        private void CmbComplex_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbComplex.SelectedIndex)
            {
                case 0:
                    complex = A * DegreeDeComplxiteDuProjet;
                    break;
                case 1:
                    complex = B * DegreeDeComplxiteDuProjet;
                    break;
                case 2:
                    complex = C * DegreeDeComplxiteDuProjet;
                    break;
                case 3:
                    complex = D * DegreeDeComplxiteDuProjet;
                    break;
                case 4:
                    complex = E * DegreeDeComplxiteDuProjet;
                    break;
            }

            guna2Chip6.Visible = true;
            guna2Chip6.Text = complex.ToString();
            Resultat();
        }

        private void CmbInnovant_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInnovant.SelectedIndex)
            {
                case 0:
                    innovant = A * CaractereInnovation;
                    break;
                case 1:
                    innovant = B * CaractereInnovation;
                    break;
                case 2:
                    innovant = C * CaractereInnovation;
                    break;
                case 3:
                    innovant = D * CaractereInnovation;
                    break;
                case 4:
                    innovant = E * CaractereInnovation;
                    break;
            }

            guna2Chip5.Visible = true;
            guna2Chip5.Text = innovant.ToString();
            Resultat();
        }

        private void CmbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSkills.SelectedIndex)
            {
                case 0:
                    skills = A * SkillsDevelop;
                    break;
                case 1:
                    skills = B * SkillsDevelop;
                    break;
                case 2:
                    skills = C * SkillsDevelop;
                    break;
                case 3:
                    skills = D * SkillsDevelop;
                    break;
                case 4:
                    skills = E * SkillsDevelop;
                    break;
            }

            guna2Chip2.Visible = true;
            guna2Chip2.Text = skills.ToString();
            Resultat();
        }

        private void Guna2Chip5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void BtnEvaluer_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void CmbP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectPropertyController property = new ProjectPropertyController();
            ProjectPropertyModel model = property.GetModel(cmbP.SelectedItem.ToString(), P);

            if (cmbP.SelectedItem.ToString() == model.NumberProject)
            {
                lblStatus.Text = model.Status;
                lblNum.Text = model.ProjectName;
                lblPercent.Text = model.DonePercent.ToString();
                lblstrag.Text = model.Strategy;
            }
            
        }
    }
}
