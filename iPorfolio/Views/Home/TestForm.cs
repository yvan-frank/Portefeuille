using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace iPorfolio.Views.Home
{
    public partial class TestForm : Form
    {
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

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            CriteriaController criteria = new CriteriaController();
            

            foreach (CriteriaModel model in criteria.GetAll())
            {
                try
                {
                    cmbCoMission.StartIndex = 0;
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

           
        }

        private void Resultat()
        {
            result = coefMission + strategy + urgency + stable + soutien + duree + cout + resource + risk + complex +
                     innovant + skills;

            lblResult.Text = result.ToString();
            lblResult.Invoke(new Action(() =>
            {
                lblResult.Text = result.ToString();
            }));
        }
        int result = 0;
        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch (cmbCoMission.SelectedIndex)
            {
                case 0:
                    coefMission = A * CoherenceDegreeWithTheMission;
                    textBox1.Text = coefMission.ToString();
                    break;
                case 1:
                    coefMission = B * CoherenceDegreeWithTheMission;
                    textBox1.Text = coefMission.ToString();
                    break;
                case 2:
                    coefMission = C * CoherenceDegreeWithTheMission;
                    textBox1.Text = coefMission.ToString();
                    break;
                case 3:
                    coefMission = D * CoherenceDegreeWithTheMission;
                    textBox1.Text = coefMission.ToString();
                    break;
                case 4:
                    coefMission = E * CoherenceDegreeWithTheMission;
                    textBox1.Text = coefMission.ToString();
                    break;
            }

            Resultat();

        }
        int coefMission = 0;
        private void CmbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cmbStrategy.SelectedIndex)
            {
                case 0:
                    strategy = A * AlignmentWithTheEnterpriseStrategy;
                    textBox2.Text = strategy.ToString();
                    break;
                case 1:
                    strategy = B * AlignmentWithTheEnterpriseStrategy;
                    textBox2.Text = strategy.ToString();
                    break;
                case 2:
                    strategy = C * AlignmentWithTheEnterpriseStrategy;
                    textBox2.Text = strategy.ToString();
                    break;
                case 3:
                    strategy = D * AlignmentWithTheEnterpriseStrategy;
                    textBox2.Text = strategy.ToString();
                    break;
                case 4:
                    strategy = E * AlignmentWithTheEnterpriseStrategy;
                    textBox2.Text = strategy.ToString();
                    break;
            }
            Resultat();
        }
        int strategy = 0;
        private void CmbUrgence_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbUrgence.SelectedIndex)
            {
                case 0:
                    urgency = A * UrgencyProjectDegree;
                    textBox2.Text = urgency.ToString();
                    break;
                case 1:
                    urgency = B * UrgencyProjectDegree;
                    textBox2.Text = urgency.ToString();
                    break;
                case 2:
                    urgency = C * UrgencyProjectDegree;
                    textBox2.Text = urgency.ToString();
                    break;
                case 3:
                    urgency = D * UrgencyProjectDegree;
                    textBox2.Text = urgency.ToString();
                    break;
                case 4:
                    urgency = E * UrgencyProjectDegree;
                    textBox2.Text = urgency.ToString();
                    break;
            }
            Resultat();
        }
        int urgency = 0;
        private void CmbStable_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cmbStable.SelectedIndex)
            {
                case 0:
                    stable = A * ObjectiveProjectStability;
                    textBox2.Text = stable.ToString();
                    break;
                case 1:
                    stable = B * ObjectiveProjectStability;
                    textBox2.Text = stable.ToString();
                    break;
                case 2:
                    stable = C * ObjectiveProjectStability;
                    textBox2.Text = stable.ToString();
                    break;
                case 3:
                    stable = D * ObjectiveProjectStability;
                    textBox2.Text = stable.ToString();
                    break;
                case 4:
                    stable = E * ObjectiveProjectStability;
                    textBox2.Text = stable.ToString();
                    break;
            }
            Resultat();
        }
        int stable = 0;
        private void CmbSoutien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbSoutien.SelectedIndex)
            {
                case 0:
                    soutien = A * SoutienDesPartiesPrenantes;
                    textBox2.Text = soutien.ToString();
                    break;
                case 1:
                    soutien = B * SoutienDesPartiesPrenantes;
                    textBox2.Text = soutien.ToString();
                    break;
                case 2:
                    soutien = C * SoutienDesPartiesPrenantes;
                    textBox2.Text = soutien.ToString();
                    break;
                case 3:
                    soutien = D * SoutienDesPartiesPrenantes;
                    textBox2.Text = soutien.ToString();
                    break;
                case 4:
                    soutien = E * SoutienDesPartiesPrenantes;
                    textBox2.Text = soutien.ToString();
                    break;
            }
            Resultat();
        }
        int soutien = 0;
        private void CmbDuree_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbDuree.SelectedIndex)
            {
                case 0:
                    duree = A * DureeDuProjet;
                    textBox2.Text = duree.ToString();
                    break;
                case 1:
                    duree = B * DureeDuProjet;
                    textBox2.Text = duree.ToString();
                    break;
                case 2:
                    duree = C * DureeDuProjet;
                    textBox2.Text = duree.ToString();
                    break;
                case 3:
                    duree = D * DureeDuProjet;
                    textBox2.Text = duree.ToString();
                    break;
                case 4:
                    duree = E * DureeDuProjet;
                    textBox2.Text = duree.ToString();
                    break;
            }
            Resultat();
        }
        int duree = 0;
        private void CmbCout_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbCout.SelectedIndex)
            {
                case 0:
                    cout = A * CoutduProjet;
                    textBox2.Text = cout.ToString();
                    break;
                case 1:
                    cout = B * CoutduProjet;
                    textBox2.Text = cout.ToString();
                    break;
                case 2:
                    cout = C * CoutduProjet;
                    textBox2.Text = cout.ToString();
                    break;
                case 3:
                    cout = D * CoutduProjet;
                    textBox2.Text = cout.ToString();
                    break;
                case 4:
                    cout = E * CoutduProjet;
                    textBox2.Text = cout.ToString();
                    break;
            }
            Resultat();
        }
        int cout = 0;
        private void Cmbressource_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cmbressource.SelectedIndex)
            {
                case 0:
                    resource = A * DisponibilteDesRessources;
                    textBox2.Text = resource.ToString();
                    break;
                case 1:
                    resource = B * DisponibilteDesRessources;
                    textBox2.Text = resource.ToString();
                    break;
                case 2:
                    resource = C * DisponibilteDesRessources;
                    textBox2.Text = resource.ToString();
                    break;
                case 3:
                    resource = D * DisponibilteDesRessources;
                    textBox2.Text = resource.ToString();
                    break;
                case 4:
                    resource = E * DisponibilteDesRessources;
                    textBox2.Text = resource.ToString();
                    break;
            }
            Resultat();
        }
        int resource = 0;
        private void CmdRisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmdRisk.SelectedIndex)
            {
                case 0:
                    risk = A * DegreeDeRiskDuringSonExecution;
                    textBox2.Text = risk.ToString();
                    break;
                case 1:
                    risk = B * DegreeDeRiskDuringSonExecution;
                    textBox2.Text = risk.ToString();
                    break;
                case 2:
                    risk = C * DegreeDeRiskDuringSonExecution;
                    textBox2.Text = risk.ToString();
                    break;
                case 3:
                    risk = D * DegreeDeRiskDuringSonExecution;
                    textBox2.Text = risk.ToString();
                    break;
                case 4:
                    risk = E * DegreeDeRiskDuringSonExecution;
                    textBox2.Text = risk.ToString();
                    break;
            }
            Resultat();
        }
        int risk = 0;
        private void CmbComplex_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbComplex.SelectedIndex)
            {
                case 0:
                    complex = A * DegreeDeComplxiteDuProjet;
                    textBox2.Text = complex.ToString();
                    break;
                case 1:
                    complex = B * DegreeDeComplxiteDuProjet;
                    textBox2.Text = complex.ToString();
                    break;
                case 2:
                    complex = C * DegreeDeComplxiteDuProjet;
                    textBox2.Text = complex.ToString();
                    break;
                case 3:
                    complex = D * DegreeDeComplxiteDuProjet;
                    textBox2.Text = complex.ToString();
                    break;
                case 4:
                    complex = E * DegreeDeComplxiteDuProjet;
                    textBox2.Text = complex.ToString();
                    break;
            }
            Resultat();
        }
        int complex = 0;
        private void CmbInnovant_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInnovant.SelectedIndex)
            {
                case 0:
                    innovant = A * CaractereInnovation;
                    textBox2.Text = innovant.ToString();
                    break;
                case 1:
                    innovant = B * CaractereInnovation;
                    textBox2.Text = innovant.ToString();
                    break;
                case 2:
                    innovant = C * CaractereInnovation;
                    textBox2.Text = innovant.ToString();
                    break;
                case 3:
                    innovant = D * CaractereInnovation;
                    textBox2.Text = innovant.ToString();
                    break;
                case 4:
                    innovant = E * CaractereInnovation;
                    textBox2.Text = innovant.ToString();
                    break;
            }
            Resultat();
        }
        int innovant = 0;
        private void CmbSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cmbSkills.SelectedIndex)
            {
                case 0:
                    skills = A * SkillsDevelop;
                    textBox2.Text = skills.ToString();
                    break;
                case 1:
                    skills = B * SkillsDevelop;
                    textBox2.Text = skills.ToString();
                    break;
                case 2:
                    skills = C * SkillsDevelop;
                    textBox2.Text = skills.ToString();
                    break;
                case 3:
                    skills = D * SkillsDevelop;
                    textBox2.Text = skills.ToString();
                    break;
                case 4:
                    skills = E * SkillsDevelop;
                    textBox2.Text = skills.ToString();
                    break;
            }
            Resultat();
        }
        int skills = 0;

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
           
            //int dateDebut = guna2DateTimePicker1.Value.ToLongDateString();
            //int dateFin = guna2DateTimePicker2.Value.ToLongDateString();

            TimeSpan tss = guna2DateTimePicker1.Value - guna2DateTimePicker2.Value;
            string sw = tss.TotalDays.ToString("####");

            
            lblDate.Text = sw;
        }
    }
}
