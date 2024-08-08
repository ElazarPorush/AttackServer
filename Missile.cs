using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    public class Missile
    {
        public string name { get; set; }
        public int speed { get; set; }
        public int mass { get; set; }
        public Origin origin { get; set; }
        public Angle angle { get; set; }
    }

    public class Origin
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public class Angle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
