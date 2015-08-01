using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _01.Database_First;
namespace _02.ExportManufactAndModelsAsJSON
{
    class ExportCamerasToJSON
    {
        static void Main(string[] args)
        {
            var context = new PhotographySystemEntities();

            var manufcators = context.Manufacturers
                .Select(m => new
                {
                    manufacturer = m.Name,
                    cameras = m.Cameras.OrderBy(c => c.Model).Select(c => new
                   {
                       model = c.Model,
                       price = c.Price
                   }),
                }).OrderBy(m => m.manufacturer);
            // to use the jsSerializer we must import System.Web.Extensions from references
            var json = new JavaScriptSerializer().Serialize(manufcators);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../manufactureres-and-cameras.json", json);
        }
    }
}
