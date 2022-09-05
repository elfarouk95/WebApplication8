using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication8.Model
{
    public class SchoolDb : DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                   Server = DESKTOP-60PFG0M\MSSQLSERVER01; 
                   DataBase = SchoolDb2;
                   Trusted_Connection = true; ");
        }

    }
}
