using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;

namespace Adds
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new AdsContext();
            Console.WriteLine(db.Ads.Count());

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            WithoutInclude(db);

            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Restart();

            WithInclude(db);

            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Stop();

        }

        private static void WithInclude(AdsContext db)
        {
            var adds = db.Ads
                .Include(a => a.Town)
                .Include(a => a.AdStatus)
                .Include(a => a.Category)
                .Include(a => a.Town)
                .Include(a => a.AspNetUser);
            foreach (var add in adds)
            {
                Console.WriteLine(add.Title + " " + add.AdStatus.Status + " " +
                                  (add.Category == null ? " no category " : add.Category.Name) + " " +
                                  (add.Town == null ? " no town " : add.Town.Name) + " " +
                                  (add.AspNetUser == null ? " no user " : add.AspNetUser.Name)
                    );
            }
        }

        private static void WithoutInclude(AdsContext db)
        {
            var adds = db.Ads;

            foreach (var add in adds)
            {
                Console.WriteLine(add.Title + " " + add.AdStatus.Status + " " +
                                  (add.Category == null ? " no category " : add.Category.Name) + " " +
                                  (add.Town == null ? " no town " : add.Town.Name) + " " +
                                  (add.AspNetUser == null ? " no user " : add.AspNetUser.Name)
                    );
            }
        }
    }
}
