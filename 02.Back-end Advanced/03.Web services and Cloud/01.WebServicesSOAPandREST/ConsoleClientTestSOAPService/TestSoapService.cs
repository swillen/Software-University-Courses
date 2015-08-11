using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClientTestSOAPService.ServiceCalcDistance;

namespace ConsoleClientTestSOAPService
{
    class TestSoapService
    {
        static void Main(string[] args)
        {
            Point a = new Point(){X = 3, Y = 5};
            Point b = new Point(){X = 10,Y = 2};
            DistanceCalculatorClient c = new DistanceCalculatorClient();
            
            var result = c.CalculateDistance(a, b);
            Console.WriteLine(result);
        }
    }
}
