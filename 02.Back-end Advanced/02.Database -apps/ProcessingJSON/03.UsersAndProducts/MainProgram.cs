using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProductsShop.Data;

namespace _03.UsersAndProducts
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var db = new ProductsShopContext();
            //01.   Get all users who have at least 1 sold product. Order them by the number of sold products (from highest to lowest), then by last name (ascending). Select only their first and last name, age and for each product - name and price.Export the results to XML. Follow the format below to better understand how to structure your data. 

            var users = db.Users
                .Where(u => u.ProductsSold.Count > 0)
                .Select(u => new
                {
                    FirstName = (u.FirstName == null ? null : u.FirstName),
                    LastName = u.LastName,
                    Age = (u.Age == null ? null : u.Age),
                    Products = u.ProductsSold.Select(p => new
                    {
                        name = p.Name,
                        price = p.Price
                    }),
                    NumbOfSoldProducts = u.ProductsSold.Count
                }).OrderByDescending(u => u.NumbOfSoldProducts).ThenBy(u => u.LastName);

            var usersXML = new XElement("users",
                new XAttribute("count", users.Count()));
            foreach (var user in users)
            {
                var userInfoXMl = new XElement("user");
                string firstName = user.FirstName;
                string lastName = user.LastName;
                string age = user.Age.ToString() =="" ? null : user.Age.ToString();


                if (firstName != null)
                {
                    userInfoXMl.Add(new XAttribute("first-name",firstName));
                }
                userInfoXMl.Add(new XAttribute("last-name",lastName));
                if (age != null)
                {
                    userInfoXMl.Add( new XAttribute("age",age));
                }
                var products = user.Products;

                var productsSoldXML = new XElement("sold-products",new XAttribute("count",products.Count()));

                userInfoXMl.Add(productsSoldXML);
                foreach (var product in products)
                {
                    
                    var productXMl = new XElement("product");
                    productXMl.Add(new XAttribute("name", product.name));
                    productXMl.Add(new XAttribute("price", product.price));
                    productsSoldXML.Add(new XElement(productXMl));
                }
                

                usersXML.Add(userInfoXMl);
            }

            
            Console.WriteLine(usersXML);
            usersXML.Save("../../users.xml");       

        }
    }
}
