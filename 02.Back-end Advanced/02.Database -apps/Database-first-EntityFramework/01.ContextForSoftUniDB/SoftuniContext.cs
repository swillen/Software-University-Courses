using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ContextForSoftUniDB;

namespace ContextForSoftUniDB
{
    class SoftuniContext
    {
        static void Main(string[] args)
        {
            SoftUniEntities dbo = new SoftUniEntities();
            Employee firstEmp = new Employee()
            {
                EmployeeID = 329,
                FirstName = "Aleks",
                LastName = "Aleksieva",
                AddressID = 3,
                DepartmentID = 5,
                JobTitle = "Neshto si",
                Salary = 600,
                HireDate = DateTime.Now.AddDays(10)
            };
            DAO.Insert(firstEmp);

            Employee empToModifyOrDelete = dbo.Employees.Where(x => x.FirstName == "Aleks").FirstOrDefault();

            Employee e = DAO.FindByKey(205);

            Console.WriteLine(e);

            DAO.Modify(empToModifyOrDelete);

            DAO.Delete(empToModifyOrDelete, dbo);
        }


    }
}
