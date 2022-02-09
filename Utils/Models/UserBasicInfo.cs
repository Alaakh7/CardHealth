using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class UserBasicInfo
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string NationalNumbser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; } 
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        //زمرة الدم
        public bool IsMale { get; set; }
        public bool IsActive { get; set; }

        public List<PhoneNumber> phoneNumbers { get; set; }
        public List<UserSensitive> UserSensitives { get; set; }
        public List<UserChronicDisease> UserChronicDiseases { get; set; }
        public List<TherapeuticStage> TherapeuticStages { get; set; }
    }
}