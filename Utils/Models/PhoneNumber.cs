using Utils.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public UserBasicInfo User { get; set; }
        public int? HealingPointId { get; set; }
        public HealingPoint HealingPoint { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; } 
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
