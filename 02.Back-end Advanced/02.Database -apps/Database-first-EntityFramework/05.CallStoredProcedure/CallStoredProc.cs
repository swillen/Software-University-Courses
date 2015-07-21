using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CallStoredProcedure
{
    class CallStoredProc
    {
        static void Main(string[] args)
        {
            var db = new SoftUniEntities();

            var projects = db.usp_ProjectsForGivenEmployee("Ruth", "Ellerbrock");
            foreach (var project in projects)
            {
                Console.WriteLine("{0} {1} {2}",project.Name,project.Description,project.StartDate);
            }
        }
    }
}
