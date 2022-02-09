using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class TherapeuticStage
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserBasicInfo User { get; set; }
        public DateTime StartingDate { get; set; }
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; } 
        public string Reason { get; set; }
        public int HealingPointId { get; set; }
        public HealingPoint HealingPoint { get; set; }
        public string Note { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}