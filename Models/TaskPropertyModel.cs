using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TaskPropertyModel
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string NumberProject { get; set; }
        public string FunctionName { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public int? DonePercent { get; set; }
        public string Priority { get; set; }
        public int Progress { get; set; }
    }
}
