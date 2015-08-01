using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using _01.Database_First;

namespace _03.ExportPhotographsAsXML
{
    class ExportPhotogrAsXML
    {
        static void Main(string[] args)
        {
            // Ensure date formatting will use the English names
            Encoding asciiEncoding = Encoding.UTF8;


            var context = new PhotographySystemEntities();

            var photographs = context.Photographs
                .Select(p => new
                {
                    PhotographTitle = p.Title,
                    Category = p.Category.Name,
                    CameraLink = p.Link,
                    CameraPixelsAttribute = p.Equipment.Camera.Megapixels == null ? String.Empty : p.Equipment.Camera.Megapixels.Value.ToString(),
                    CameraManAndModel = p.Equipment.Camera.Manufacturer.Name + " " + p.Equipment.Camera.Model,
                    LensModel = p.Equipment.Lens.Manufacturer.Name+" "+ p.Equipment.Lens.Model,
                    LensPriceAttribute = p.Equipment.Lens.Price
                }).OrderBy(p=>p.PhotographTitle).ToList();

            var photographsXML = new XElement("photographs");

            foreach (var photograph in photographs)
            {
                var photographXML = new XElement("photograph",
                    new XAttribute("title", photograph.PhotographTitle),
                    new XElement("category", photograph.Category),
                    new XElement("link", photograph.CameraLink)
                    );
                var equipment = new XElement("equipment");
                
                    var cameraXML = new XElement("camera",photograph.CameraManAndModel);
                    if (photograph.CameraPixelsAttribute != null)
                    {
                        cameraXML.Add(new XAttribute("megapixels",photograph.CameraPixelsAttribute));
                    }

                    var lens = new XElement("lens",photograph.LensModel);
                    if (photograph.LensPriceAttribute != null)
                    {

                        lens.Add(new XAttribute("price", string.Format("{0:f2}", photograph.LensPriceAttribute)));
                    }
                    equipment.Add(cameraXML);
                    equipment.Add(lens);
                photographXML.Add(equipment);

                photographsXML.Add(photographXML);
            }
            Console.WriteLine(photographsXML);
            photographsXML.Save("../../photographs.xml");
        }
    }
}
