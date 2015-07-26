using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsSystem.Data;
using NewsSystem.Models;

namespace NewsSystem.ConsoleClient
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var db = new NewsContext();
            bool hasChange = false;
            var firstUser = new NewsContext();
            var secondUser = new NewsContext();
            int id = 1;

            ChangeContentValue(firstUser,id,ref  hasChange);
            Console.WriteLine(hasChange);
            ChangeContentValue(secondUser, id,ref  hasChange);
            
            firstUser.SaveChanges();
            try
            {
               
                    secondUser.SaveChanges();
                
            }
            catch (DbUpdateConcurrencyException )
            {

                Console.WriteLine("Conflict! Text from DB: ");
                PrintNewsContent(id);
                ChangeContentValue(secondUser,id,ref hasChange);
                Console.WriteLine("Changes successfully saved in the DB.");
            }

        }

        private static void ChangeContentValue(NewsContext db, int id, ref bool hasChange)
        {
            var article = db.News.Find(id).Content;
            Console.WriteLine("Please enter content : ");
            var newContent = Console.ReadLine();
            db.News.Find(id).Content = newContent;
            if (hasChange == false)
            {
                Console.WriteLine("Changes successfully saved in the DB.");
            }
            hasChange = true;
        }


        private static void PrintNewsContent(int id)
        {
            var db = new NewsContext();
            var newsToChange = db.News.Find(id);
            Console.WriteLine(newsToChange.Content);
            
        }
    }
}
