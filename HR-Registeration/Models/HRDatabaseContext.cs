using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Registeration.Models
{
    public class HRDatabaseContext:DbContext

    {
        public DbSet<RaysLab> Rays_Lab { get; set; }

        public DbSet<AnalysisLab> Analysis_Lab { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = DESKTOP-AN76OET\SQLEXPRESS  ;initial catalog=LabsDB  ; integrated security = SSPI;");
        }

    }
}
