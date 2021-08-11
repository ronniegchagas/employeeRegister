using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace employeeRegister.Models
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>();

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}