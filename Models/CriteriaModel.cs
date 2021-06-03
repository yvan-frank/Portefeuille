
namespace Models
{
    class CriteriaModel
    {
        public int CriteriaId { get; set; }
        public enum CoherenceDegreeWithTheMission
        {
            FortementIncoherent = -2,
            UnPeuIncoherent = -1,
            Neutral = 0,
            Coherent = 1,
            RenforceLaMission = 2
        }

        public enum AlignmentWithTheEnterpriseStrategy
        {
            FortementIncoherent = -2,
            UnPeuIncoherent = -1,
            Neutral = 0,
            Coherent = 1,
            AppuiLaStrategy = 2
        }

        public enum UrgencyProjectDegree
        {
            TresUrgent = -2,
            AssezPresse = -1,
            Normal = 0,
            Flexible = 1,
            SansDelayPrecis = 2
        }

        public enum ObjectiveProjectStability
        {
            Chaotik = -2,
            Inconstant = -1,
            RiskModere = 0,
            RelativementStable = 1,
            TresStable = 2
        }

        public enum SoutienDesPartiesPrenantes
        {
            ForteOpposition = -2,
            QuelqueOpposition = -1,
            Equilibre = 0,
            BonSoutien = 1,
            SoutienIncondionnel = 2
        }

        public enum DureeDuProjet
        {
            TresLong = -2,
            Long = -1,
            Normal = 0,
            Court = 1,
            TresCourt = 2
        }

        public enum CoutduProjet
        {
            VeryHigh = -2,
            High = -1,
            Moyen = 0,
            BonMarche = 1,
            PresaueSansCout = 2
        }

        public enum DisponibilteDesRessources
        {
            PasDeRessource = -2,
            PeuDeRessource = -1,
            PeutEtreAllouer = 0,
            FalcilementDisponible = 1,
            DisponibleEtLibre = 2
        }

        public enum DegreeDeRiskDuringSonExecution
        {
            TresRisk = -2,
            RiskMoyen = -1,
            PeuDeRisk = 0,
            PresqueSansRisk = 1,
            SansAucunRisk = 2
        }

        public enum DegreeDeComplxiteDuProjet
        {
            TresComplex = -2,
            Complex = -1,
            MoyennementComplex = 0,
            AssezSimple = 1,
            TresSimple = 2
        }

        public enum CaractereInnovation
        {
            Obslete = -2,
            SansAucuneNouveaute = -1,
            QuelqueNouveaute = 0,
            Innovant = 1,
            Revolutionnaire = 2
        }
       
    }
}
