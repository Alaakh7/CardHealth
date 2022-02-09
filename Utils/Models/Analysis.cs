using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Models.Enums;

namespace Utils.Models
{
    public class Analysis
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Details { get; set; }
        public AnalysisType AnalysisType { get; set; }
    }
}
