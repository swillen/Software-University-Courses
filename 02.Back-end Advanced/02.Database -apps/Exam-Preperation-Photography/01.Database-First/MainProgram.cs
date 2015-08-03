using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Database_First
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            var context = new PhotographySystemEntities();
            var cameras = context.Cameras
                .Select(x => x.Manufacturer.Name + " " + x.Model)
                .OrderBy(x => x);
            Console.WriteLine(string.Join("\n", cameras)); // replace the foreach loop 

            //foreach (var camera in cameras)
            //{
            //    Console.WriteLine(camera);
            //}
        }
    }
}
