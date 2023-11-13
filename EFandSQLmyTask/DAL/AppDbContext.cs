using EFandSQLmyTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFandSQLmyTask.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-PV5O637;database=AB104EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
