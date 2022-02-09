using Utils.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class AnalysisInfo
    {
        public int Id { get; set; }
        public int AnalysisId { get; set; }
        public Analysis Analysis { get; set; }
        public string Details { get; set; }
        public int HealingPointId { get; set; } 
        public HealingPoint HealingPoint { get; set; }
        //with userId
    }
}
