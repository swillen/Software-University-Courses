using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NativeSQLQuery
{
    class Test
    {
        static SoftUniEntities context = new SoftUniEntities();
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            PrintNamesWithNativeQuery();
            Console.WriteLine("Native {0}",sw.Elapsed); //Native 00:00:00.1793477

            sw.Restart();

            PrintNamesWithLinqQuery();
            Console.WriteLine("Linq {0}",sw.Elapsed); //Linq 00:00:00.1958006
        }

        private static void PrintNamesWithNativeQuery()
        {
            var query = "SELECT DISTINCT e.FirstName " +
                        "FROM Employees e " +
                        "JOIN EmployeesProjects ep " +
                        "ON e.EmployeeID = ep.EmployeeID " +
                        "JOIN Projects p " +
                        "ON ep.ProjectID = p.ProjectID " +
                        "WHERE YEAR(p.StartDate) = 2002 " +
                        "ORDER BY e.FirstName ";
            var result = context.Database.SqlQuery<string>(query).ToList();
            foreach (var emp in result)
            {
                Console.WriteLine(emp);
            }
        }

        private static void PrintNamesWithLinqQuery()
        {
            var employeesProjects = context.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year == 2002))
                .GroupBy(e => e.FirstName)
                .OrderBy(e => e.Key)
                .Select(e => e.Key);
            foreach (var employeesProject in employeesProjects)
            {
                Console.WriteLine(employeesProject);
            }
        }
    }
}
