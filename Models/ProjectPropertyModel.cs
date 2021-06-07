using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProjectPropertyModel
    {
        public string NumberProject { get; set; }
        public string FunctionName { get; set; }
        public int? Cost { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
    }
}
