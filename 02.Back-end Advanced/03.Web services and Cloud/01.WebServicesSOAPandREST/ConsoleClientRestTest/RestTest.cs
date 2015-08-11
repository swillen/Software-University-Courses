using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalcDistanceSOAPService;
using RestSharp;

namespace ConsoleClientRestTest
{
    class RestTest
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {

                // Download data.
                var result = client.UploadString("http://localhost:3169/calcdistance?startPoint=20,4&endPoint=5,6", "POST");

                Console.WriteLine(result);
            }

        }
    }
}
