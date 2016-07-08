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
            GiantPlanet planet1 = new GiantPlanet("gas", "jupiter", 2016.25, 49954548.1150);
            TerrestrialPlanet planet2 = new TerrestrialPlanet(true, "earth", 6400, 456874);
            planet2.ToString();
            

        }
    }
}
