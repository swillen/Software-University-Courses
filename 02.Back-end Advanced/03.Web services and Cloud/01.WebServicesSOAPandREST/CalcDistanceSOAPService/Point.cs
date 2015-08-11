using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CalcDistanceSOAPService
{
    [DataContract]
    public class Point
    {
        [DataMember]
        public int  X { get; set; }

        [DataMember]
        public int Y { get; set; }

        public Point(int x , int y )
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            throw new NotImplementedException();
        }
    }
}