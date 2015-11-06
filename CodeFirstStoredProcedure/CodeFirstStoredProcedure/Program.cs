using System;
using System.Linq;

namespace CodeFirstStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeDbContext dbContext = new EmployeeDbContext())
            {
                string commandText = "[dbo].[usp_GetAllEmployees]";
                var employees = dbContext.Database.SqlQuery<Employee>(commandText).ToList();

                Console.WriteLine("Printing Employee");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.EmployeeId);
                    Console.WriteLine(employee.FirstName);
                    Console.WriteLine(employee.LastName);
                    Console.WriteLine(employee.Designation);
                    Console.WriteLine("-----------------");
                }
            }
            Console.ReadKey();
        }
    }
}
