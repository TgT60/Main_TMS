using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HwWithoutDeadLine.Models
{
    public class SupporSpecialist
    {
        public Guid ID { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string SurName { get; set; }
        public Department Department { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string StatusSpecialist { get; set; }
    }
}
