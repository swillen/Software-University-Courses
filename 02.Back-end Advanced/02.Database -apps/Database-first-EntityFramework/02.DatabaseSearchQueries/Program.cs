using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DatabaseSearchQueries
{
    class Program
    {
        static SoftUniEntities context = new SoftUniEntities();
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a task number ( 1,2,3,4 or END ) :");
            
            string task = Console.ReadLine();
            while (task!= "END" && task!="end")
            {
                switch (task)
                {
                    case "1":
                        EmpWithProjectsInPeriod();
                        break;

                    case "2":
                        AdressesWithNumbEmployees();
                        break;
                    case "3":
                        Console.WriteLine("Please enter employee ID :");
                        int id = int.Parse(Console.ReadLine());
                        EmployeyById(id);
                        break;
                    case "4":
                        DepartmenstMoreThan5Employees();
                        break;
                        
                }
                task = Console.ReadLine();

            }

        }

        private static void DepartmenstMoreThan5Employees()
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .Select(d => new
                {
                    d.Name,
                    manager = d.Employee.LastName,
                    d.Employees.Count,
                    d.Employees
                });
            foreach (var department in departments)
            {
                Console.WriteLine("-- {0} - Manager : {1} Employees: {2}", department.Name, department.manager, department.Count);
                var employees = department.Employees;
                Console.WriteLine("Employees list: ");
                foreach (var employee in employees)
                {
                    Console.WriteLine("     {0} {1} {2} {3}", employee.FirstName, employee.LastName, employee.HireDate.Year,
                        employee.JobTitle);
                }
                Console.WriteLine();
            }
        }

        private static void EmployeyById( int id)
        {
            var employeeById = context.Employees
                .Where(e => e.EmployeeID == id)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    ProjectName = e.Projects.OrderBy(p => p.Name).Select(p => p.Name)
                }).FirstOrDefault();
            Console.WriteLine("--Name : {0} {1} ", employeeById.FirstName, employeeById.LastName);
            Console.WriteLine("--Project Name(s): ");
            foreach (var empById in employeeById.ProjectName)
            {
                Console.WriteLine(empById);
            }
        }

        private static void AdressesWithNumbEmployees()
        {
            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count).ThenBy(a => a.Town.Name)
                .Select(a => new
                {
                    Adress = a.AddressText,
                    Town = a.Town.Name,
                    EmpNumber = a.Employees.Count
                })
                .Take(10);
            foreach (var address in addresses)
            {
                Console.WriteLine("{0} , {1} - {2} employee(s)", address.Adress, address.Town, address.EmpNumber);
            }
        }

        private static void EmpWithProjectsInPeriod()
        {
            var projects = context.Projects
                .Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003)
                .Select(e=>new
                {
                    e.Name,
                    e.Employees
                });
            foreach (var project in projects)
            {
                var emp = project.Employees;
                Console.WriteLine("Project name: " + project.Name);
                foreach (var employee in emp)
                {
                    Console.WriteLine("      Employee name: " + employee.FirstName);
                }
                Console.WriteLine();
            }
        }
    }
}

