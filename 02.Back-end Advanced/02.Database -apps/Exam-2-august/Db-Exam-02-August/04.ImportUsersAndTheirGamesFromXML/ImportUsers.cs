using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using _01.Database_First;

namespace _04.ImportUsersAndTheirGamesFromXML
{
    class ImportUsers
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            var db = new DiabloContext();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../users-and-games.xml");

            var root = doc.DocumentElement;
            foreach (XmlNode user in root)
            {

                try
                {

                var userFirstName = user.Attributes["first-name"] == null ? null : user.Attributes["first-name"].Value;
                var userLastName = user.Attributes["last-name"] == null ? null : user.Attributes["last-name"].Value;
                var userEmail = user.Attributes["email"] == null ? null : user.Attributes["email"].Value;
                var userUserName = user.Attributes["username"] == null ? null : user.Attributes["username"].Value;

                bool userIsDeleted = user.Attributes["is-deleted"].Value == "0" ? true : false;
                var userIpAddress = user.Attributes["ip-address"] == null ? null : user.Attributes["ip-address"].Value;
                DateTime userRegistracionDate = DateTime.ParseExact(user.Attributes["registration-date"].Value, "dd/MM/yyyy", null);

                User userDb = null;

                if (db.Users.Any(u => u.Username == userUserName))
                {
                    Console.WriteLine("User {0} already exists", userUserName);
                }
                else
                {
                    userDb = new User()
                    {
                        Username = userUserName,
                        Email = userEmail,
                        FirstName = userFirstName,
                        IpAddress = userIpAddress,
                        IsDeleted = userIsDeleted,
                        LastName = userLastName,
                        RegistrationDate = userRegistracionDate
                    };
                    db.Users.Add(userDb);
                    
                    Console.WriteLine("Successfully added user {0}", userUserName);

                    foreach (XmlNode games in user.ChildNodes)
                    {
                        foreach (XmlNode game in games)
                        {

                            var gameName = game["game-name"].InnerText;
                            var CharacterName = game["character"].Attributes["name"].Value;
                            var CharacterCash = game["character"].Attributes["cash"].Value;
                            var CharacterLevel = game["character"].Attributes["level"].Value;
                            var joinedOn = game["joined-on"].InnerText;

                            var dbGame = db.Games.Where(g => g.Name == gameName).FirstOrDefault();

                           
                                
                             UsersGame ug = new UsersGame()
                            {
                                Game = db.Games.Where(g => g.Name == gameName).FirstOrDefault(),
                                User = userDb,
                                Cash = Convert.ToDecimal(CharacterCash),
                                Level = Convert.ToInt32(CharacterLevel),
                                JoinedOn = DateTime.ParseExact(joinedOn, "dd/MM/yyyy", null),
                                Character = new Character()
                                {
                                    Name = CharacterName
                                }
                            };
                            db.UsersGames.Add(ug);
                            db.SaveChanges();
                            Console.WriteLine("User {0} successfully added to game {1}", userDb.Username, gameName);

                        }
                    }
                }
                
                }
                catch (Exception e )
                {

                }
              
            }
        }
    }
}
