using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MoviesDb.Data;
using MoviesDb.Models;
using MoviesDb.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MoviesDb.ConsoleClient
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var context = new MoviesContext();


            Console.WriteLine(context.Countries.Count());

        }
    }
}
