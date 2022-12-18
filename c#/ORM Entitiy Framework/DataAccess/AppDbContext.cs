using Microsoft.EntityFrameworkCore;
using ORM_Entitiy_Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Entitiy_Framework.DataAccess
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O87JGVH\SQL_SERVER;Database=COMPANY2;Trusted_Connection=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
