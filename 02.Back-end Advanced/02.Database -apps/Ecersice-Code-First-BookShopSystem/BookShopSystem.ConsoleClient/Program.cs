using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopSystem.Data;

namespace BookShopSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.First we make the models - BookShopSystem.Models - contains all the classes with theyr properties (class library) 
            //2.1. Then we make the data layer - in it we insert the code first model 
            //2.2. import references (from models) and inset DbSets from the models ( class library)-->public virtual dbset<author>..
            //2.3. then we fix the app.config file - change the connection string -initial catalog and data source
            //3.1. then we make ...Console client (Console Application) and reference the Models and the Data 
            //3.2. in it we also install Entity Framework thrue Nuget Package Manager 
            //3.3. we copy the connection string from the ...Data model and paste it in the app.config in ConsoleClient
            //3.4. finally to create the database we must execute any action thrue the context
            // * to make restrictions we must add reference = > .. annotation 


            var db = new BookShopContext();

            //1.	Get all books after the year 2000. Select only their titles.

            //BooksReleasedAfter2000(db);

            //2.	Get all authors with at least one book with release date before 1990. Select their first name and last name.

            //FilterAuthorsByBookCountAndReleaseDate(db);

            //3.	Get all authors, ordered by the number of their books (descending).
            //Select their first name, last name and book count.

            //AuthorsOrderedByBookCount(db);

            //4.   Get all books from author George Powell, ordered by their release date (descending),
            //then by book title (ascending).Select the book's title, release date and copies.

            //BooksFromAuthorName(db);

            //5.  Get the most recent books by categories. The categories should be ordered by total book count. Only take the top 3 most recent books from each category - ordered by date (descending), then by title (ascending). Select the category name, total book count and for each book - its title and release date.

            RelatedBooksByCategory(db);
        }

        private static void RelatedBooksByCategory(BookShopContext db)
        {
            var categories = db.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    BookCount = c.Books.Count,
                    Books =
                        c.Books.Select(b => new {b.Title, b.ReleaseDate})
                            .OrderByDescending(b => b.ReleaseDate)
                            .ThenBy(b => b.Title)
                }).OrderByDescending(c => c.BookCount);

            foreach (var category in categories)
            {
                Console.WriteLine("--"+category.CategoryName + ", " + category.BookCount +" books");
                var books = category.Books;
                foreach (var book in books)
                {
                    Console.WriteLine("         " + book.Title + " " +"("+ book.ReleaseDate.Value.Year+")");
                }
            }
        }

        private static void BooksFromAuthorName(BookShopContext db)
        {
            var books = db.Books
                .Where(b => b.Author.FirstName == "George" && b.Author.LastName == "Powell")
                .OrderByDescending(b => b.ReleaseDate).ThenBy(b => b.Title)
                .Select(b => new
                {
                    b.Title,
                    b.ReleaseDate,
                    b.Copies,
                    AuthorName = b.Author.FirstName + " " + b.Author.LastName
                });
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + " " + book.ReleaseDate + " " + book.ReleaseDate + " " + book.AuthorName);
            }
        }

        private static void AuthorsOrderedByBookCount(BookShopContext db)
        {
            var authors = db.Authors
                .Select(a => new
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    BookCount = a.Books.Count
                }).OrderByDescending(a => a.BookCount);
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName + " " + author.BookCount);
            }
        }

        private static void FilterAuthorsByBookCountAndReleaseDate(BookShopContext db)
        {
            var authors = db.Authors
                .Where(a => a.Books.Count > 0)
                .Where(a => a.Books
                    .Any(b => b.ReleaseDate.Value.Year < 1990))
                .Select(a => new
                {
                    a.FirstName,
                    Books = a.Books.Where(b => b.ReleaseDate.Value.Year < 1990).Select(b => new
                    {
                        b.Title,
                        b.ReleaseDate.Value.Year
                    })
                })
                .OrderBy(a => a.FirstName);

            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " --> book count:  " + author.Books.Count());
                var books = author.Books;
                Console.WriteLine("Books:");
                foreach (var book in books)
                {
                    Console.WriteLine("         " + book.Title + " " + book.Year);
                }
            }
        }

        private static void BooksReleasedAfter2000(BookShopContext db)
        {
            var books = db.Books
                .Where(b => b.ReleaseDate.Value.Year >= 2000)
                .Select(b => new
                {
                    b.Title,
                    b.ReleaseDate.Value.Year
                }).OrderBy(b => b.Year);
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + " " + book.Year);
            }
        }
    }
}
