

using System;

namespace Models
{
    public class EvaluationClassModel
    {
        public string[] IdEvaluation { get; set; }
        public DateTime EvaluationDate { get; set; }
        public string[] Score { get; set; }
        public string[] ProjectNumber { get; set; }

        //les criteres
        public string[] CoherenceDegreeWithTheMission { get; set; }
        public string[] AlignmentWithTheEnterpriseStrategy { get; set; }
        public string[] UrgencyProjectDegree { get; set; }
        public string[] ObjectiveProjectStability { get; set; }
        public string[] SoutienDesPartiesPrenantes { get; set; }
        public string[] DureeDuProjet { get; set; }
        public string[] CoutduProjet { get; set; }
        public string[] DisponibilteDesRessources { get; set; }
        public string[] DegreeDeRiskDuringSonExecution { get; set; }
        public string[] DegreeDeComplxiteDuProjet { get; set; }
        public string[] CaractereInnovation { get; set; }
        public string[] SkillsDevelop { get; set; }
    }
}
