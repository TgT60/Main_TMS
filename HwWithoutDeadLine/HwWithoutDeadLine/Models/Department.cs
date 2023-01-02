using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HwWithoutDeadLine.Models
{
    public class Department
    {
        public Guid ID { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Title { get; set; }
    }
}
