using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        //type "override on", select the method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed(); 
        }
    }
}
