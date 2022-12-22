using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwWithoutDeadLine.Models
{
    public class LogicContext : DbContext
    {

        public LogicContext(DbContextOptions<LogicContext> options) : base(options)
        { 
        }
        public DbSet<SupportRequest> SupportRequest { get; set; }
        public DbSet<SupporSpecialist> SupporSpecialist { get; set; }
        public DbSet<Department> Department  { get; set; }


    }
}
