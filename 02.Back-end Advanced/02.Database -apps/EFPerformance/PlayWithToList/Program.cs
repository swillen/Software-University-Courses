using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adds;

namespace PlayWithToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var db= new AdsContext();
            Console.WriteLine(db.Ads.Count());
            Console.WriteLine("---Non Optimized ");
            var sw = new Stopwatch();
            sw.Start();

            var totalNoNOptimizedTime = 0;
            var totalOptimizedTime = 0;

            var nonOpitmizedTotalTime = 0;
            for (int i = 0; i < 10; i++)
            {
                db.Database.ExecuteSqlCommand(@"CHECKPOINT; DBCC DROPCLEANBUFFERS;");
                NonOptimized(db);
                var timeToRun = sw.Elapsed;
                totalNoNOptimizedTime += timeToRun.Milliseconds;
                Console.WriteLine("Time : "+timeToRun.Milliseconds);
                sw.Restart();
            }
            Console.WriteLine("Average time :"+totalNoNOptimizedTime/10);
            Console.WriteLine();
            Console.WriteLine("---Optimized");
            sw.Restart();
            for (int i = 0; i < 10; i++)
            {
                db.Database.ExecuteSqlCommand(@"CHECKPOINT; DBCC DROPCLEANBUFFERS;");
                Optimized(db);
                var timeToRun = sw.Elapsed;
                totalOptimizedTime += timeToRun.Milliseconds;
                Console.WriteLine("Time : "+timeToRun.Milliseconds);
                sw.Restart();
            }
            Console.WriteLine("Average time :"+ totalOptimizedTime/10);
        }

        private static void Optimized(AdsContext db)
        {
           
            var adds = db.Ads
                .Where(a => a.AdStatus.Status == "Published")
                .Select(a => new
                {
                    a.Title,
                    Category = (a.Category == null ? " null" : a.Category.Name),
                    Town = (a.Town == null ? " null " : a.Town.Name),
                    a.Date
                }).OrderBy(a => a.Date).ToList();
        }

        private static void NonOptimized(AdsContext db)
        {
            var adds = db.Ads.ToList()
                .Where(a => a.AdStatus.Status == "Published")
                .Select(a => new
                {
                    a.Title,
                    Category = (a.Category == null ? " null" : a.Category.Name),
                    Town = (a.Town == null ? " null " : a.Town.Name),
                    a.Date
                }).ToList().OrderBy(a => a.Date);
        }
    }
}
