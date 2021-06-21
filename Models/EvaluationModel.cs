using System;
namespace Models
{
    public class EvaluationModel
    {
        public int? IdEvaluation { get; set; }
        public DateTime? EvaluationDate { get; set; }
        public int? Score { get; set; }
        public string ProjectNumber { get; set; }

        //les criteres
        public int? CoherenceDegreeWithTheMission { get; set; }
        public int? AlignmentWithTheEnterpriseStrategy { get; set; }
        public int? UrgencyProjectDegree { get; set; }
        public int? ObjectiveProjectStability { get; set; }
        public int? SoutienDesPartiesPrenantes { get; set; }
        public int? DureeDuProjet { get; set; }
        public int? CoutduProjet { get; set; }
        public int? DisponibilteDesRessources { get; set; }
        public int? DegreeDeRiskDuringSonExecution { get; set; }
        public int? DegreeDeComplxiteDuProjet { get; set; }
        public int? CaractereInnovation { get; set; }
        public int? SkillsDevelop { get; set; }
    }
}
