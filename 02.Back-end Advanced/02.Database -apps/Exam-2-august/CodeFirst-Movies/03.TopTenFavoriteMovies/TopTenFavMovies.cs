using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using MoviesDb.Data;
using MoviesDb.Models.Enums;

namespace _03.TopTenFavoriteMovies
{
    class TopTenFavMovies
    {
        static void Main(string[] args)
        {
            var db  =new MoviesContext();

            var topFavMovies = db.Movies
                .Where(m => m.AgeRestriction == AgeRestriction.Teen)
                .OrderByDescending(m => m.Users.Count).ThenBy(m => m.Title)
                .Select(m => new
                {
                    isbn = m.ISBN,
                    title = m.Title,
                    favouritedBy = m.Users.Select(u => u.UserName),
                }).Take(10);
            var json = new JavaScriptSerializer().Serialize(topFavMovies);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../top-10-favourite-movies.json", json);

            

        }
    }
}
