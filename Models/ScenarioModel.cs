
using System;

namespace Models
{
    public class ScenarioModel
    {
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EnDate { get; set; }
        public double Cost { get; set; }
        public int Status { get; set; }
        public int State { get; set; }
        public decimal ExternalBudget { get; set; }
        public DateTime CloseDate { get; set; }
        public  DateTime EstimatedDate { get; set; }
        public int DonePercent { get; set; }
    }
}
