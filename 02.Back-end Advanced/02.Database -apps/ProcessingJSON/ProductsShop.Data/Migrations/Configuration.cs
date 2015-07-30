using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;
using ProductsShop.Models;

namespace ProductsShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductsShop.Data.ProductsShopContext>
    {
        public Configuration()
        {
            //AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "ProductsShop.Data.ProductsShopContext";
        }

        protected override void Seed(ProductsShop.Data.ProductsShopContext context)
        {
            if (context.Users.Count() == 0)
            {
                XDocument doc = XDocument.Load("../../users.xml");

                ImportUsers(context, doc);

                AddRandomFriendsToUsers(context);
            }

           
            if (context.Categories.Count() == 0)
            {
                ImportCategories(context);
            }
            if (context.Products.Count() == 0)
            {
                ImportProducts(context);
            }
            
        }

        private static void AddRandomFriendsToUsers(ProductsShopContext context)
        {
            Random rnd = new Random();

            var usersList = context.Users.ToList();


            for (int i = 0; i < usersList.Count; i++)
            {
                var randomFriendIndex1 = rnd.Next(0, context.Users.Count());
                var randomFriendIndex2 = rnd.Next(0, context.Users.Count());

                usersList[i].Friends.Add(usersList[randomFriendIndex1]);
                usersList[randomFriendIndex1].Friends.Add(usersList[i]);

                if (randomFriendIndex2 != randomFriendIndex1)
                {
                    usersList[i].Friends.Add(usersList[randomFriendIndex2]);
                    usersList[randomFriendIndex2].Friends.Add(usersList[i]);
                }
            }
            context.SaveChanges();
        }

        private static void ImportCategories(ProductsShopContext context)
        {
            using (StreamReader reader = new StreamReader("../../categories.json"))
            {
                Categorie[] categories = JsonConvert.DeserializeObject<Categorie[]>(reader.ReadToEnd());
                foreach (var category in categories)
                {
                    context.Categories.Add(category);
                }
                context.SaveChanges();
            }
        }

        private static void ImportProducts(ProductsShopContext context)
        {
            Random rnd = new Random();
            using (StreamReader reader = new StreamReader("../../products.json"))
            {
                Product[] products = JsonConvert.DeserializeObject<Product[]>(reader.ReadToEnd());
                foreach (var product in products)
                {
                    //adds random buyers -if  index%5 !=0 we add buyer else none 
                    var buyerIndex = rnd.Next(0, context.Users.Count());
                    if (buyerIndex % 5 != 0)
                    {
                        product.Buyer = context.Users.ToList()[buyerIndex];
                    }

                    //adds random seller 
                    var sellerIndex = rnd.Next(0, context.Users.Count());
                    product.Seller = context.Users.ToList()[sellerIndex];

                    //adds random categories
                    var categoryIndex1 = rnd.Next(0, context.Categories.Count());
                    var categoryIndex2 = rnd.Next(0, context.Categories.Count());
                    var categoryIndex3 = rnd.Next(0, context.Categories.Count());

                    HashSet<Categorie> categories = new HashSet<Categorie>()
                    {
                        context.Categories.ToList()[categoryIndex1],
                        context.Categories.ToList()[categoryIndex2],
                        context.Categories.ToList()[categoryIndex3]
                    };

                    product.Categories = categories;
                    context.Products.Add(product);
                }
            }
            context.SaveChanges();
        }

        private static void ImportUsers(ProductsShopContext context, XDocument doc)
        {
            var users =
                (from user in doc.Descendants("user")
                    select new
                    {
                        FirstName = user.Attribute("first-name") != null ? user.Attribute("first-name").Value : null,
                        LastName = user.Attribute("last-name").Value,
                        Age = user.Attribute("age") != null ? user.Attribute("age").Value : null
                    }).ToList();
            foreach (var user in users)
            {
                User u = new User()
                {
                    FirstName = user.FirstName == String.Empty ? "" : user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age!=null ? int.Parse(user.Age) : (int?) null
                };
                context.Users.AddOrUpdate(u);
            }
            context.SaveChanges();
        }
    }
}
