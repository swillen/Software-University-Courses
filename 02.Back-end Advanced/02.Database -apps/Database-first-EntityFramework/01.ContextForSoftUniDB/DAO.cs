using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ContextForSoftUniDB;

namespace ContextForSoftUniDB
{
     public static class DAO
     {
         
         public static void Insert(Employee e)
         {
            SoftUniEntities db = new SoftUniEntities();
             db.Employees.Add(e);
             db.SaveChanges();
         }

        public static Employee FindByKey(Object key)
        {
            SoftUniEntities dbe = new SoftUniEntities();

            Employee e = dbe.Employees.Find(key);
            return e;

        }

         public static void Modify(Employee e)
         {
            SoftUniEntities db = new SoftUniEntities();
             var employee = db.Employees.Find(e.EmployeeID);
             employee.FirstName = "Modify";
             employee.LastName = "Made";
             db.SaveChanges();

         }

         public static void Delete(Employee e,SoftUniEntities db)
         {
             if (e != null)
             {
                 db.Employees.Remove(e);
                 db.SaveChanges();
                 Console.WriteLine("Succesfully deleted " + e.FirstName);
             }
         }

    }
}
