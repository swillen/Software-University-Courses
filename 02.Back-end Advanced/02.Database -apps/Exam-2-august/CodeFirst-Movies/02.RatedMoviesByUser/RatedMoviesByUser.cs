using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using MoviesDb.Data;

namespace _02.RatedMoviesByUser
{
    class RatedMoviesByUser
    {
        static void Main(string[] args)
        {
            var context = new MoviesContext();

            var userName = "jmeyery";

            var ratedMoviesByUser = context.Users
                .Where(u => u.UserName == userName)
                .Select(u => new
                {
                    username = u.UserName,
                    ratedMovies = u.Ratings.Select(r=> new
                    {
                        title = r.Movie.Title,
                        userRating = r.Stars,
                        averageRating =  r.Movie.Ratings.Average(a=>a.Stars)
                    })
                });
            var json = new JavaScriptSerializer().Serialize(ratedMoviesByUser);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../rated-movies-by-jmeyery.json", json);

        }
    }
}
