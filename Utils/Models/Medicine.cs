using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ElseMedicineId { get; set; }
        public Medicine ElseMedicine { get; set; }
        public string Details { get; set; }
    }
}
