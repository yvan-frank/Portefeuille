using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int? IsJalon { get; set; }
        public DateTime? PlanDate { get; set; }
        public int? Duration { get; set; }
        public int? ActualBudget { get; set; }
        public int? Progress { get; set; }
        public DateTime? DelayExecution { get; set; }
    }
}
