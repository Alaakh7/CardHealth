using Utils.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utils.Models
{
    public class HealingPoint
    {
        [ForeignKey("Account")]
        public int Id { get; set; }
        public Account Account { get; set; }
        public string Name { get; set; }
        public HealingPointType HealingPointType { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Note { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; } 
        public List<UserChronicDisease> UserChronicDiseases { get; set; }
        public List<UserSensitive> UserSensitives { get; set; } 
        public List<AnalysisInfo> AnalysisInfos { get; set; }
        public List<TherapeuticStage> TherapeuticStages { get; set; }
    }
}
