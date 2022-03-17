using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee
                   {
                       Id = 1,
                       Name = "Rajan",
                       Department = Dept.IT,
                       Email = "rajan@gmail.com"

                   },
                   new Employee
                   {
                       Id = 2,
                       Name = "Kumar",
                       Department = Dept.HR,
                       Email = "kumar@gmail.com"

                   }
               );
        }
    }
}
