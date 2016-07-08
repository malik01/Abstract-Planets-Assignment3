using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet jupiter = new GiantPlanet("Gaseous", "jupiter", 2016.25, 49954548.1150);
            TerrestrialPlanet earth = new TerrestrialPlanet(true, "Earth", 6400, 456874);
            jupiter.MoonCount = 2;
            jupiter.RingCount = 4;
            jupiter.ToString();
            earth.ToString();
            

        }
    }
}
