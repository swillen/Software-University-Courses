using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using MoviesDb.Data;
using MoviesDb.Models.Enums;

namespace _01.AdultMovies
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var context = new MoviesContext();
            var adultsMovies = context.Movies
                .Where(m => m.AgeRestriction == AgeRestriction.Adult)
                .Select(m => new
                {
                    title = m.Title,
                    ratingsGiven = m.Ratings.Count
                }).OrderBy(m=>m.title).ThenBy(m=>m.ratingsGiven);

            var json = new JavaScriptSerializer().Serialize(adultsMovies);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../adult-movies.json", json);
        }
    }
}
