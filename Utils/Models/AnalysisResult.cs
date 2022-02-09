using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class AnalysisResult
    {
        public int Id { get; set; } 
        //delete
        public int HealingPointId { get; set; }
        public HealingPoint HealingPoint { get; set; }
        public int UserBasicInfoId { get; set; }
        public UserBasicInfo UserBasicInfo { get; set; }
        public DateTime AddedDate { get; set; }
        public string Note { get; set; }
        //delete
        public bool IsActive { get; set; }
        public List<AnalysisResultFile> AnalysisResultFiles { get; set; }
    }
}
