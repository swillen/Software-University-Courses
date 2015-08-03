using MoviesDb.Models;
using MoviesDb.Models.Enums;
using Newtonsoft.Json.Linq;

namespace MoviesDb.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesDb.Data.MoviesContext>
    {
        public Configuration()
        {
            //AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "MoviesDb.Data.MoviesContext";
        }

        protected override void Seed(MoviesDb.Data.MoviesContext context)
        {
            if (context.Countries.Count() == 0)
            {
                AddCountries(context);
            }
            if (context.Movies.Count() == 0)
            {
                AddMovies(context);
            }
            if (context.Users.Count() == 0)
            {
                AddUsers(context);

                AddFavoriteMovies(context);
            }
            if (context.Ratings.Count() == 0)
            {
                AddRatings(context);
            }
        }

        private static void AddFavoriteMovies(MoviesContext context)
        {
            string text = System.IO.File.ReadAllText("../../../users-and-favourite-movies.json");

            JArray usersWithMovies = JArray.Parse(text);

            foreach (JObject userMovies in usersWithMovies)
            {
                string userName = userMovies["username"].ToString();

                var movies = userMovies["favouriteMovies"];
                User userToUpdate = context.Users.Where(u => u.UserName.ToLower() == userName.ToLower()).FirstOrDefault();

                Movie[] movieList = new Movie[movies.Count()];
                int count = 0;
                foreach (var movie in movies)
                {
                    string isbn = movie.ToString();


                    Movie movieToAdd = context.Movies.Where(m => m.ISBN == isbn).FirstOrDefault();


                    userToUpdate.Movies.Add(movieToAdd);
                    context.SaveChanges();
                }
            }
        }

        private static void AddRatings(MoviesContext context)
        {
            string text = System.IO.File.ReadAllText("../../../movie-ratings.json");

            JArray users = JArray.Parse(text);

            foreach (JObject userObj in users)
            {
                string user = userObj["user"].ToString();
                string movieISBN = userObj["movie"].ToString();
                int rating = int.Parse(userObj["rating"].ToString());

                context.Ratings.Add(new Rating()
                {
                    User = context.Users.Where(u => u.UserName == user).FirstOrDefault(),
                    Movie = context.Movies.Where(m => m.ISBN == movieISBN).FirstOrDefault(),
                    Stars = rating,
                });
                context.SaveChanges();
            }
        }

        private static void AddUsers(MoviesContext context)
        {
            string text = System.IO.File.ReadAllText("../../../users.json");

            JArray users = JArray.Parse(text);

            foreach (JObject user in users)
            {
                //Console.WriteLine(country["name"]);
                string userName = user["username"].ToString();
                string age = user["age"].ToString();
                string email = user["email"].ToString();
                string countryName = user["country"].ToString();
                context.Users.Add(new User()
                {
                    UserName = userName,
                    Age = age.ToString() == String.Empty ? (int?)null : int.Parse(age),
                    Email = email == String.Empty ? null : email,
                    Country = context.Countries.Where(c => c.Name == countryName).FirstOrDefault(),
                });
                context.SaveChanges();
            }
        }

        private static void AddMovies(MoviesContext context)
        {
            string text = System.IO.File.ReadAllText("../../../movies.json");

            JArray movies = JArray.Parse(text);

            foreach (JObject movie in movies)
            {
                string movieName = movie["title"].ToString();
                string isbn = movie["isbn"].ToString();
                AgeRestriction restr = (AgeRestriction) int.Parse(movie["ageRestriction"].ToString());

                context.Movies.Add(new Movie()
                {
                    Title = movieName,
                    AgeRestriction = restr,
                    ISBN = isbn,
                });
                context.SaveChanges();
            }
        }

        private static void AddCountries(MoviesContext context)
        {
            string text = System.IO.File.ReadAllText("../../../countries.json");

            JArray countries = JArray.Parse(text);

            foreach (JObject country in countries)
            {
                string countryName = country["name"].ToString();
                context.Countries.Add(new Country()
                {
                    Name = countryName
                });
                context.SaveChanges();
            }
        }
    }
}
