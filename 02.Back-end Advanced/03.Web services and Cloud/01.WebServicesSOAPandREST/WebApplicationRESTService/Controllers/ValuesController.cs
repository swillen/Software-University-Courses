using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationRESTService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        [HttpPost]
        [Route("calcdistance")]
        public double CalculateDistance(Point startPoint, Point endPoint)
        {
            
            var distance = Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2);
            return Math.Sqrt(distance);
        }
    }
}
