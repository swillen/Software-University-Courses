using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConcurentDatabaseChanges
{
    class ConcurentDbChange
    {
        static void Main(string[] args)
        {
            var db1 = new SoftUniEntities();
            var db2 = new SoftUniEntities();

            var town = db1.Towns.Find(2).Name = "Seul";  //old - calgary
            var town2 = db2.Towns.Find(2).Name = "Jeju";
            db1.SaveChanges();
            db1.SaveChanges();
        }
    }
}
