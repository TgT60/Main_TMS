using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HwWithoutDeadLine.Models
{
    public class SupportRequest
    {
        [Column("SupportRequestID")]
        public Guid ID { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Description { get; set; }
        public SupporSpecialist SpecialistStatus { get; set; }
        public SupporSpecialist Specialist { get; set; }

    }
}
