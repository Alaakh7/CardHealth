using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class AnalysisResultFile
    {
        public int Id { get; set; }
        public int AnalysisResultId { get; set; }
        public AnalysisResult AnalysisResult { get; set; }
        public string FilePath { get; set; }
    }
}
