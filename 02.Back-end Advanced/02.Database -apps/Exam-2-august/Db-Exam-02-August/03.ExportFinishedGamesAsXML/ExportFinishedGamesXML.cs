using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _01.Database_First;

namespace _03.ExportFinishedGamesAsXML
{
    class ExportFinishedGamesXML
    {
        static void Main(string[] args)
        {
            var db = new DiabloContext();
            var finishedGames = db.Games
                .Where(g => g.IsFinished == true)
                .Select(g => new
                {
                    GameName = g.Name,
                    GameDuration = g.Duration,
                    Users = g.UsersGames.Select(ug=>new
                    {
                        UserName = ug.User.Username,
                        IpAddress = ug.User.IpAddress
                    })
                }).OrderBy(g=>g.GameName).ThenBy(g=>g.GameDuration);

            var XMLgames  = new XElement("games");
            foreach (var finishedGame in finishedGames)
            {
                var finishedGameXML = new XElement("game");
                finishedGameXML.Add(new XAttribute("name",finishedGame.GameName));
                if (finishedGame.GameDuration != null)
                {
                    finishedGameXML.Add(new XAttribute("duration",finishedGame.GameDuration));
                }

                if (finishedGame.Users.Count() != 0)
                {
                    var usersXML = new XElement("users");

                    var users = finishedGame.Users;
                    foreach (var user in users)
                    {
                        var userXML = new XElement("user",
                            new XAttribute("username", user.UserName),
                            new XAttribute("ip-address", user.IpAddress));
                        usersXML.Add(userXML);
                    }

                    finishedGameXML.Add(new XElement(usersXML));
                }
                else
                {
                    finishedGameXML.Add(new XElement("users"));
                }
                

                XMLgames.Add(finishedGameXML);
            }

            XMLgames.Save("../../finished-games.xml");
            Console.WriteLine(XMLgames);
        }
    }
}
