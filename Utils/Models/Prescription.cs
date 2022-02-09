using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public int? MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int? AnalysisId { get; set; }
        public Analysis Analysis { get; set; }
        public int TherapeuticStageId { get; set; }
        public TherapeuticStage TherapeuticStage { get; set; }
        public int count { get; set; }
        public string Note { get; set; }
    }
}
