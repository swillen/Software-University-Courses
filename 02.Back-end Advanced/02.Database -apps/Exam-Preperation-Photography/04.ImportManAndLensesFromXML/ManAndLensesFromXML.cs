using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using _01.Database_First;

namespace _04.ImportManAndLensesFromXML
{
    internal class ManAndLensesFromXML
    {
        private static void Main(string[] args)
        {
            var context = new PhotographySystemEntities();

            XmlDocument doc = new XmlDocument();
            doc.Load("../../manufacturers-and-lenses.xml");

            var root = doc.DocumentElement;
            int id = 1;
            foreach (XmlNode manufacturer in doc.DocumentElement)
            {
                Console.WriteLine("Processing  # {0}", id++);
                var manufacturerChilds = manufacturer.ChildNodes;

                var manufacturerName = manufacturerChilds[0].InnerXml;

                Manufacturer XmlManufacturer = new Manufacturer();

                if (context.Manufacturers.Any(m => m.Name == manufacturerName))
                {
                    Console.WriteLine("Existing manufacturer: {0}", manufacturerName);
                }
                else
                {
                    Console.WriteLine("Created manufacturer: {0}",manufacturerName);
                    XmlManufacturer.Name = manufacturerName;
                    context.Manufacturers.Add(XmlManufacturer);
                    context.SaveChanges();

                }

                XmlNode lenses = manufacturerChilds[1];
                if (lenses != null)
                {
                    foreach (XmlNode lense in lenses)
                    {
                        string lenseModel = lense.Attributes["model"].Value;
                        string lenseType = lense.Attributes["type"].Value;
                        string lensePrice = lense.Attributes["price"] == null ? null : lense.Attributes["price"].Value;

                        if (context.Lenses.Any(l => l.Model == lenseModel))
                        {
                            Console.WriteLine("Existing lens: {0}", lenseModel);
                        }
                        else
                        {
                            Lens lens = new Lens()
                            {
                                Model = lenseModel,
                                Type = lenseType,
                                Price = lensePrice == null ? (decimal?)null : Decimal.Parse(lensePrice),
                                Manufacturer = context.Manufacturers.FirstOrDefault                                           (m=>m.Name==manufacturerName)
                            };
                            context.Lenses.Add(lens);
                            context.SaveChanges();
                            Console.WriteLine("Created lens: {0}",lenseModel);
                        }

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
