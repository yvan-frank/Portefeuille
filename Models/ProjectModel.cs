using System;

namespace Models
{
    public class ProjectModel
    {
        public int ProjectId { get; set; } 
        public  string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string Category { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime EstimatedDate { get; set; }
        public string ChefProject { get; set; }
        public int Cost { get; set; }
        public int State { get; set; }
        public int Status { get; set; }
        public decimal InternalBudget { get; set; }
        public decimal ExternalBudget { get; set; }
        public decimal ReturnOfInvestment { get; set; }
        public DateTime CloseDate { get; set; }
        public int DonePercent { get; set; }

    }
}
