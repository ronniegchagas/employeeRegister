namespace employeeRegister.Migrations
{
    using employeeRegister.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<employeeRegister.Models.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(employeeRegister.Models.EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {
                    Name = "Carson",
                    Address = "Alexander",
                    BirthDate = DateTime.Parse("2010-09-01"),
                    Salary = 100
                },
                new Employee {
                    Name = "Carson",
                    Address = "Alexander",
                    BirthDate = DateTime.Parse("2010-09-01"),
                    Salary = 100
                },
                new Employee {
                    Name = "Carson",
                    Address = "Alexander",
                    BirthDate = DateTime.Parse("2010-09-01"),
                    Salary = 100
                },
                new Employee {
                    Name = "Carson",
                    Address = "Alexander",
                    BirthDate = DateTime.Parse("2010-09-01"),
                    Salary = 100
                }
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();
        }
    }
}
