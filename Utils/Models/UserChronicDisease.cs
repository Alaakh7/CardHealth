using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class UserChronicDisease
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserBasicInfo User { get; set; }
        public int ChronicDiseaseId { get; set; }
        public ChronicDisease ChronicDisease { get; set; }
        public int HealingPointId { get; set; }
        public HealingPoint HealingPoint { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public string Note { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
