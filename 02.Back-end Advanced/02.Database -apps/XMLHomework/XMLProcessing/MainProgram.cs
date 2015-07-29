using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLProcessing
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../Catalog.xml");
            //2.Write a program that extracts all album names from catalog.xml. Use the DOM parser.
            
            ExtractAllAlbumNames(doc);

            //3.Write a program that extracts all artists in alphabetical order from catalog.xml. Use the DOM parser. Keep the artists in a SortedSet<string> to avoid duplicates and to keep the artist in alphabetical order.

            ExtractArtistsAlphabetical(doc);

            //4.Write a program that extracts all different artists, which are found in the catalog.xml. For each artist print the number of albums in the catalogue. Use the DOM parser and a Dictionary<string, int> (use the artist name as key and the number of albums as value in the dictionary).

            DOMArtistsNumberOfAlbums(doc);

            //5.XPath: Extract Artists and Number of Albums

            XPathExtractArtistAndNumbOfAlbums(doc);

            //6.Using the DOM parser write a program to delete from catalog.xml all albums having price > 20. Save the result in a new file cheap-albums-catalog.xml.

            DeleteFromCatalogFiltetByPrice(doc);

            //7.Write a program, which extract from the file catalog.xml the titles and prices for all albums, published 5 years ago or earlier. Use XPath query.

            DOMAlbumsPublished5YearsAgo(doc);

            XPathAlbumsPublished5YearsAgo(doc);

            //8.Write a program, which extract from the file catalog.xml the titles and prices for all albums, published 5 years ago or earlier. Use XDocument and LINQ to XML query
            XDocument xmlDoc = XDocument.Load("../../catalog.xml");

            LINQAlbumsPublished5YearsAgo(xmlDoc);
        }

        private static void LINQAlbumsPublished5YearsAgo(XDocument xmlDoc)
        {
            var albums =
                (from album in xmlDoc.Descendants("album")
                    where int.Parse(album.Element("year").Value) >= DateTime.Now.Year - 5
                    select new
                    {
                        Name = album.Attribute("name").Value,
                        Price = album.Element("price").Value
                    }).ToList();

            foreach (var album in albums)
            {
                Console.WriteLine("Album name: " + album.Name + " ,Price: " + album.Price);
            }
        }

        private static void XPathAlbumsPublished5YearsAgo(XmlDocument doc)
        {
            var albumsQuery = "(/catalog/album[year>=2010]/@name)|(/catalog/album[year>=2010]/price)";

            XmlNodeList filteredAlbums = doc.SelectNodes(albumsQuery);
            foreach (XmlNode filteredAlbum in filteredAlbums)
            {
                Console.WriteLine(filteredAlbum.InnerText);
            }
        }

        private static void DOMAlbumsPublished5YearsAgo(XmlDocument doc)
        {
            var albums = doc.DocumentElement;

            var filteredAlbums = albums.Cast<XmlNode>()
                .Where(a => (DateTime.Now.Year) - (int.Parse(a["year"].InnerText)) <= 5)
                .Select(a => new
                {
                    Title = a.Attributes["name"].Value,
                    Price = a["price"].InnerText
                }).ToList();
            foreach (var filteredAlbum in filteredAlbums)
            {
                Console.WriteLine(filteredAlbum.Title + " " + filteredAlbum.Price);
            }
        }

        private static void DeleteFromCatalogFiltetByPrice(XmlDocument doc)
        {
            var albumsNode = doc.DocumentElement;
            //albumsNode
            //    .Cast<XmlNode>()
            //    .ToList()
            //    .ForEach(a => { Console.WriteLine("{0}, price: {1}", a.Attributes["name"].Value, a["price"].InnerText); });

            Console.WriteLine("Please enter price to filter by : ");
            decimal price = decimal.Parse(Console.ReadLine());
            var deleteAlbums = albumsNode
                .Cast<XmlNode>()
                .Where(a => decimal.Parse(a["price"].InnerXml) > price);

            for (int i = 0; i < deleteAlbums.Count(); i++)
            {
                XmlNode album = deleteAlbums.ToList()[i];
                album.ParentNode.RemoveChild(album);
                i--;
            }
            doc.Save("../../cheap-albums-catalog.xml");
        }

        private static void XPathExtractArtistAndNumbOfAlbums(XmlDocument doc)
        {
            var albums = doc.DocumentElement;

            var artistQuery = "/catalog/album/artist";
            XmlNodeList artistsList = doc.SelectNodes(artistQuery);
            foreach (XmlElement artist in artistsList)
            {
                var currentArtist = artist.InnerText;
                string albumstThathaveArtistNameQuery = "/catalog/album[artist=\"" + currentArtist + "\"]";
                var count = doc.SelectNodes(albumstThathaveArtistNameQuery).Count;
                Console.WriteLine("Artist name: " + currentArtist + " ,Count of albums: " + count);
            }
        }

        private static void DOMArtistsNumberOfAlbums(XmlDocument doc)
        {
            Dictionary<string, int> artistWihtNumberOfAlbums = new Dictionary<string, int>();

            var catalog = doc.DocumentElement;
            var result = catalog.Cast<XmlElement>()
                .GroupBy(c => c["artist"].InnerText)
                .Select(c => new
                {
                    ArtistName = c.Key,
                    AlbumsCount = c.Count()
                })
                .ToList();
            foreach (var res in result)
            {
                artistWihtNumberOfAlbums.Add(res.ArtistName, res.AlbumsCount);
            }
            artistWihtNumberOfAlbums.ToList()
                .ForEach(c => Console.WriteLine("Artist : " + c.Key + " ,Number of Albums: " + c.Value));
        }

        private static void ExtractArtistsAlphabetical(XmlDocument doc)
        {
            SortedSet<String> sortedArtists = new SortedSet<string>();
            foreach (XmlNode node in doc.DocumentElement)
            {
                sortedArtists.Add(node["artist"].InnerText);
            }
            foreach (var sortedArtist in sortedArtists)
            {
                Console.WriteLine("Artist Name :" + sortedArtist);
            }
        }

        private static void ExtractAllAlbumNames(XmlDocument doc)
        {
            foreach (XmlNode node in doc.DocumentElement)
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    Console.WriteLine("Album name : " + attribute.Value);
                }
                //1.Console.WriteLine("Album name: "+ node.Attributes["name"].Value);

                //2.
                //XmlNodeList albumNodes = node.ChildNodes;
                //foreach (XmlElement element in albumNodes)
                //{
                //    Console.WriteLine(element.Name=="name" ? element.InnerText :String.Empty);
                //}
            }
        }
    }
}
