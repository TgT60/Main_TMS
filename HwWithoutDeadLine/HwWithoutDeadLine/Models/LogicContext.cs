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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var a = new Guid("1c056f18-2284-4664-984d-384d49f1cc2d");
            //var b = new Department();
           
            //modelBuilder.Entity<SupporSpecialist>()
            //    .HasData(
            //     new SupporSpecialist() { ID = Guid.NewGuid(), Name = "Dima", SurName = "Elenevich" , Department  } 
            //    );
        }
       
    }
}
