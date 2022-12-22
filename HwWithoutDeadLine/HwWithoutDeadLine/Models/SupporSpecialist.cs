using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwWithoutDeadLine.Models
{
    public class SupporSpecialist
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Department Department { get; set; }
        public string StatusSpecialist { get; set; }
    }
}
