using System.Data.Entity;

namespace CodeFirstStoredProcedure
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
            : base("EmployeeConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}