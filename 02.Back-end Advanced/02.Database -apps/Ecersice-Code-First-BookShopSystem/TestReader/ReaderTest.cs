using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    class ReaderTest
    {
        static void Main(string[] args)
        {
            var random = new Random();
            using (var reader = new StreamReader("books.txt"))
            {
                var line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    var categories = line.Split(new[] { ' ' }, 6);
                    foreach (var categorie in categories)
                    {
                        Console.WriteLine(categorie);
                    }
                    line = reader.ReadLine();
                }
            }

        }
    }
}
