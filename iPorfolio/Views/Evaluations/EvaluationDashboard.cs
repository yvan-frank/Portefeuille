using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using iPorfolio.Views.Controls;
using Models;

namespace iPorfolio.Views.Evaluations
{
    public partial class EvaluationDashboard : Form
    {
        public string P { get; }
        public EvaluationDashboard()
        {
            InitializeComponent();
        }
        public EvaluationDashboard(string p)
        {
            InitializeComponent();
            this.P = p;
        }

        private void EvaluationDashboard_Load(object sender, EventArgs e)
        {
           
            this.Invoke(new Action((() =>
            {
                LoadDataTable();
                LoadChart();
                CartesianChart();
            })));

            try
            {
                btnScore.Text = ev.GetMaxScore().ToString();
            }
            catch
            {
                MessageBox.Show(@"Aucun projet analysé");
            }
        }
        EvaluationController ev = new EvaluationController();
        private void LoadChart()
        {
            
            ArrayList project = new ArrayList();
            ArrayList score = new ArrayList();

            try
            {
                foreach (EvaluationModel model in ev.GetModelList())
                {
                    project.Add(model.ProjectNumber);
                    score.Add(model.Score);
                }
                chart1.Series[0].Points.DataBindXY(project, score);
            }
            catch
            {
               //
            }
        }

        private void CartesianChart()
        {
            EvaluationController ev = new EvaluationController();
            ArrayList project = new ArrayList();
            ArrayList score = new ArrayList();

            try
            {
                foreach (EvaluationModel model in ev.GetModelList())
                {
                    project.Add(model.ProjectNumber);
                    score.Add(model.Score);
                }
            }
            catch
            {
                //
            }
        }
        private void LoadDataTable()
        {
            EvaluationController evaluation = new EvaluationController();
            EvaluationClassModel e = new EvaluationClassModel();
            foreach (EvaluationModel model in evaluation.GetListEvaluation())
            {
                e.ProjectNumber = new[] { model.ProjectNumber };
                e.CoherenceDegreeWithTheMission = new[] { model.CoherenceDegreeWithTheMission.ToString() };
                e.AlignmentWithTheEnterpriseStrategy = new[] { model.AlignmentWithTheEnterpriseStrategy.ToString() };
                e.UrgencyProjectDegree = new[] { model.UrgencyProjectDegree.ToString() };
                e.ObjectiveProjectStability = new[] { model.ObjectiveProjectStability.ToString() };
                e.SoutienDesPartiesPrenantes = new[] { model.SoutienDesPartiesPrenantes.ToString() };
                e.DureeDuProjet = new[] { model.DureeDuProjet.ToString() };
                e.CoutduProjet = new[] { model.CoutduProjet.ToString() };
                e.DisponibilteDesRessources = new[] { model.DisponibilteDesRessources.ToString() };
                e.DegreeDeRiskDuringSonExecution = new[] { model.DegreeDeRiskDuringSonExecution.ToString() };
                e.DegreeDeComplxiteDuProjet = new[] { model.DegreeDeComplxiteDuProjet.ToString() };
                e.CaractereInnovation = new[] { model.CaractereInnovation.ToString() };
                e.SkillsDevelop = new[] { model.SkillsDevelop.ToString() };
                e.Score = new[] {model.Score.ToString()};

                for (int i = 0; i < 1; i++)
                {
                    var con = new EvaluateControl();
                    con.Dock = DockStyle.Top;
                    con.lbProjet.Text = e.ProjectNumber[i];
                    con.lbcoherenceMission.Text = e.CoherenceDegreeWithTheMission[i];
                    if(con.lbcoherenceMission.Text.Contains("-1") || con.lbcoherenceMission.Text.Contains("-2") || con.lbcoherenceMission.Text.Contains("-3") || con.lbcoherenceMission.Text.Contains("-4") || con.lbcoherenceMission.Text.Contains("-6")) {con.lbcoherenceMission.ForeColor = Color.Red;}

                    con.lbstrategy.Text = e.AlignmentWithTheEnterpriseStrategy[i];
                    if (con.lbstrategy.Text.Contains("-1") || con.lbstrategy.Text.Contains("-2") || con.lbstrategy.Text.Contains("-3") || con.lbstrategy.Text.Contains("-4") || con.lbstrategy.Text.Contains("-6")) { con.lbstrategy.ForeColor = Color.Red; }

                    con.lbUrgence.Text = e.UrgencyProjectDegree[i];
                    if (con.lbUrgence.Text.Contains("-1") || con.lbUrgence.Text.Contains("-2") || con.lbUrgence.Text.Contains("-3") || con.lbUrgence.Text.Contains("-4") || con.lbUrgence.Text.Contains("-6")) { con.lbUrgence.ForeColor = Color.Red; }

                    con.lbStable.Text = e.ObjectiveProjectStability[i];
                    if (con.lbStable.Text.Contains("-1") || con.lbStable.Text.Contains("-2") || con.lbStable.Text.Contains("-3") || con.lbStable.Text.Contains("-4") || con.lbStable.Text.Contains("-6")) { con.lbStable.ForeColor = Color.Red; }

                    con.lbsoutien.Text = e.SoutienDesPartiesPrenantes[i];
                    if (con.lbsoutien.Text.Contains("-1") || con.lbsoutien.Text.Contains("-2") || con.lbsoutien.Text.Contains("-3") || con.lbsoutien.Text.Contains("-4") || con.lbsoutien.Text.Contains("-6")) { con.lbsoutien.ForeColor = Color.Red; }

                    con.lbduree.Text = e.DureeDuProjet[i];
                    if (con.lbduree.Text.Contains("-1") || con.lbduree.Text.Contains("-2") || con.lbduree.Text.Contains("-3") || con.lbduree.Text.Contains("-4") || con.lbduree.Text.Contains("-6")) { con.lbduree.ForeColor = Color.Red; }

                    con.lbcout.Text = e.CoutduProjet[i];
                    if (con.lbcout.Text.Contains("-1") || con.lbcout.Text.Contains("-2") || con.lbcout.Text.Contains("-3") || con.lbcout.Text.Contains("-4") || con.lbcout.Text.Contains("-6")) { con.lbcout.ForeColor = Color.Red; }

                    con.lbdispo.Text = e.DisponibilteDesRessources[i];
                    if (con.lbdispo.Text.Contains("-1") || con.lbdispo.Text.Contains("-2") || con.lbdispo.Text.Contains("-3") || con.lbdispo.Text.Contains("-4") || con.lbdispo.Text.Contains("-6")) { con.lbdispo.ForeColor = Color.Red; }

                    con.lbrisk.Text = e.DegreeDeRiskDuringSonExecution[i];
                    if (con.lbrisk.Text.Contains("-1") || con.lbrisk.Text.Contains("-2") || con.lbrisk.Text.Contains("-3") || con.lbrisk.Text.Contains("-4") || con.lbrisk.Text.Contains("-6")) { con.lbrisk.ForeColor = Color.Red; }

                    con.lbcomplex.Text = e.DegreeDeComplxiteDuProjet[i];
                    if (con.lbcomplex.Text.Contains("-1") || con.lbcomplex.Text.Contains("-2") || con.lbcomplex.Text.Contains("-3") || con.lbcomplex.Text.Contains("-4") || con.lbcomplex.Text.Contains("-6")) { con.lbcomplex.ForeColor = Color.Red; }

                    con.lbinnov.Text = e.CaractereInnovation[i];
                    if (con.lbinnov.Text.Contains("-1") || con.lbinnov.Text.Contains("-2") || con.lbinnov.Text.Contains("-3") || con.lbinnov.Text.Contains("-4") || con.lbinnov.Text.Contains("-6")) { con.lbinnov.ForeColor = Color.Red; }

                    con.lbdev.Text = e.SkillsDevelop[i];
                    if (con.lbdev.Text.Contains("-1") || con.lbdev.Text.Contains("-2") || con.lbdev.Text.Contains("-3") || con.lbdev.Text.Contains("-4") || con.lbdev.Text.Contains("-6")) { con.lbdev.ForeColor = Color.Red; }

                    con.lbScore.Text = e.Score[i];
                    if (con.lbScore.Text.Contains("-1") || con.lbScore.Text.Contains("-2") || con.lbScore.Text.Contains("-3") || con.lbScore.Text.Contains("-4") || con.lbScore.Text.Contains("-6")) { con.lbScore.ForeColor = Color.Red; }



                    pnList.Controls.Add(con);
                }


            }
        }

        private void BtnCriteria_Click(object sender, EventArgs e)
        {
            var cri = new CriteriaForm(P);
            cri.ShowInTaskbar = false;
            cri.ShowDialog();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            panChart.Visible = true;
        }
    }
}
