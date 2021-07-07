using System;

namespace Models
{
    public class ProjectPropertyModel
    {
        public string NumberProject { get; set; }
        public string ProjectName { get; set; }
        public string Strategy { get; set; }
        public string FunctionName { get; set; }
        public int? Cost { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public int? ProjectByStatus { get; set; }
        public int? DonePercent { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
