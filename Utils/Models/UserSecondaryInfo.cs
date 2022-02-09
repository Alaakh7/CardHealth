using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class UserSecondaryInfo
    {
        [ForeignKey("UserBasicInfo")]
        public int Id { get; set; }
        public UserBasicInfo userBasicInfo { get; set; }
        public string Address { get; set; }
        public string JobDetails { get; set; }
        public bool IsMaried { get; set; }
        public string MariedNames { get; set; }
        public string ChiledNames { get; set; }
    }
}