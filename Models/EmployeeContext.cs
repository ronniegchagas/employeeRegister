using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace employeeRegister.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}