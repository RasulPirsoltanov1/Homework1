using Company_Db.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Db.DataAccess
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O87JGVH\SQL_SERVER;Database=CompanyDbContext;Trusted_Connection=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
