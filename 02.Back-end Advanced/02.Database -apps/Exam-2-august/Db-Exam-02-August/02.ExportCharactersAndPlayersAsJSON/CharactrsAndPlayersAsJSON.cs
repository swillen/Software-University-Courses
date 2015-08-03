using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _01.Database_First;

namespace _02.ExportCharactersAndPlayersAsJSON
{
    class CharactrsAndPlayersAsJSON
    {
        static void Main(string[] args)
        {
            var  db = new DiabloContext();
            var charactersWithPlayers = db.Characters
                .Select(c => new
                {
                    name=c.Name,
                    playedBy = c.UsersGames.Select(ug => ug.User.Username)
                }).OrderBy(c=>c.name);
            var json = new JavaScriptSerializer().Serialize(charactersWithPlayers);
            Console.WriteLine(json);
            System.IO.File.WriteAllText(@"../../characters.json", json);
        }
    }
}
