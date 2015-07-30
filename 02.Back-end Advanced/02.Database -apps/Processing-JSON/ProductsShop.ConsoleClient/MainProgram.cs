using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProductsShop.Data;
using ProductsShop.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace ProductsShop.ConsoleClient
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var context = new ProductsShopContext();

            Console.WriteLine(context.Users.Count());
            
        }
    }
}
