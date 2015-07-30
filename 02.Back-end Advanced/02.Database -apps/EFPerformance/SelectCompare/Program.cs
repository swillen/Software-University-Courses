using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adds;

namespace SelectCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new AdsContext();
            Console.WriteLine(db.Ads.Count());
            var sw = new Stopwatch();
            sw.Stop();

            SlowVersion(db, sw);


           //OptimizedVersion(db, sw);
        }

        private static void OptimizedVersion(AdsContext db, Stopwatch sw)
        {
            var addsTitle = db.Ads.Select(a => a.Title);
            sw.Start();
            var fullSelectTime = 0;
            for (int i = 0; i < 10; i++)
            {
                db.Database.ExecuteSqlCommand(@"CHECKPOINT; DBCC DROPCLEANBUFFERS;");
                foreach (var addTitle in addsTitle)
                {
                    Console.WriteLine("         "+addTitle);
                    
                }
                var selectTime = sw.Elapsed.Milliseconds;
                Console.WriteLine(selectTime + " miliseconds");
                fullSelectTime += selectTime;
                sw.Restart();
            }

            Console.WriteLine(fullSelectTime / 10 + " miliseconds - average time ");
            sw.Stop();
        }

        private static void SlowVersion(AdsContext db, Stopwatch sw)
        {
            var addsTitle = db.Ads;
            sw.Start();
            var fullSelectTime = 0;

            for (int i = 0; i < 10; i++)
            {
                db.Database.ExecuteSqlCommand(@"CHECKPOINT; DBCC DROPCLEANBUFFERS;");
                foreach (var ad in addsTitle)
                {
                    Console.WriteLine("         "+ad.Title);
                    
                }
                var selectTime = sw.Elapsed.Milliseconds;
                Console.WriteLine(selectTime + " miliseconds");
                fullSelectTime += selectTime;
                sw.Restart();
            }
            
            Console.WriteLine(fullSelectTime/10 + " miliseconds - average time ");
            sw.Stop();
        }
    }
}
