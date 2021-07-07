using System;

namespace Models
{
    public class ProjectModel
    {
        public string NumberProject { get; set; }
        public int? PortfolioId { get; set; }
        public  string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string Category { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public decimal? EstimatedDate { get; set; }
        public DateTime? PlanGotoLive { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? FunctionName { get; set; }
        public int? Cost { get; set; }
        public int? State { get; set; }
        public int? Status { get; set; }
        public decimal? InternalBudget { get; set; }
        public decimal? ExternalBudget { get; set; }
        public decimal? ReturnOfInvestment { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? DonePercent { get; set; }

        public ProjectModel()
        {

        }

        public ProjectModel(string numberProject)
        {
            this.NumberProject = numberProject;
        }

    }
}
