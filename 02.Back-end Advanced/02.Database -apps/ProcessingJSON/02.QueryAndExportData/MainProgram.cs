using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models;
using  System.Data.Entity;
using StringExtensions;


namespace _02.QueryAndExportData
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var db = new ProductsShopContext();
            //01.   Get all products in a specified price range (e.g. 500 to 1000) which have no buyer. Order them by price (from lowest to highest). Select only the product name, price and the full name of the seller. Export the result to JSON.

            //ProductsInRangeAndWriteToJSON(db);

            //02.   Get all users who have at least 1 sold item with a buyer. Order them by last name, then by first name. Select the person's first and last name. For each of the sold products (products with buyers), select the product's name, price and the buyer's first and last name.

            //UserSoldProducts(db);

            //3.    Get all categories. Order them by the number of products in that category (a product can be in many categories). For each category select its name, the number of products, the average price of those products and the total revenue (total price sum) of those products (regardless if they have a buyer or not).

            CategoryByProductsToJSONFile(db);
        }

        private static void CategoryByProductsToJSONFile(ProductsShopContext db)
        {
            var categories = db.Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.Products.Count,
                    averagePrice = c.Products.Average(p => p.Price),
                    totalRevenue = c.Products.Sum(p => p.Price)
                }).OrderByDescending(c => c.productsCount);
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../categories-by-products.json", json);
        }

        private static void UserSoldProducts(ProductsShopContext db)
        {
            Console.BufferHeight = 1300;
            var users = db.Users
                .Where(u => u.ProductsSold.Count > 0)
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .Select(u => new
                {
                    firstName = (u.FirstName == null ? "" : u.FirstName),
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold.Where(b => b.Buyer != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = (p.Buyer.FirstName == null ? "" : p.Buyer.FirstName),
                            buyerLastName = p.Buyer.LastName
                        })
                }).OrderBy(u => u.lastName).ThenBy(u => u.firstName);

            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../users-sold-products.json", json);
        }

        private static void ProductsInRangeAndWriteToJSON(ProductsShopContext db)
        {
            var products = db.Products
                .Where(p => p.Price > 500 && p.Price < 1000)
                .Where(p => p.Buyer == null)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = (p.Seller.FirstName == null ? "" : p.Seller.FirstName) + " " + p.Seller.LastName
                }).OrderByDescending(p => p.price).ToList();

            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../products-in-range.json", json);
        }
    }
}
