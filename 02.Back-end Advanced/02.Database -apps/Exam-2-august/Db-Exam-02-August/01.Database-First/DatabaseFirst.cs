using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Database_First
{
    class DatabaseFirst
    {
        static void Main(string[] args)
        {
            var db = new DiabloContext();
            var characterNames = db.Characters.Select(c => c.Name);
            Console.WriteLine(String.Join("\n",characterNames));
        }
    }
}
