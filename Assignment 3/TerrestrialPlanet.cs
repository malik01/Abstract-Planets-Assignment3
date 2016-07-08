using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    
    class TerrestrialPlanet : Planet , IHabitable , IHasmoons 
    {
        private bool _oxygen;

        public TerrestrialPlanet(bool oxygen,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


        public bool Habitable()
        {
            if (_oxygen == true)
            {
                Console.WriteLine("| Oxygen Present {0} is habitable                                  |",Name);
                return true;
                
            }
            else
            {
                Console.WriteLine("| Oxygen absent {0} is not habitable",Name);
                return false;
            }
        }
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                Console.WriteLine("| {0} has moons orbiting around it                                 |", Name);
                return true;
            }
            else
            {
                Console.WriteLine("| {0} does not have any moons                                      |", Name);
                return false;
            }
        }
        // OVERRIDE ToString METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("\n| Planet {0} has the following properties:                         |", Name);
            Console.WriteLine("| Mass:{0} kg                                       |", Mass);
            Console.WriteLine("| Diameter:{0} km                                                  |", Diameter);
            Console.WriteLine("| Rotational Period : {0} days                                       |", RotationalPeriod);
            Console.WriteLine("| Orbital Period : {0} days                                           |", OrbitalPeriod);
            Habitable();
            HasMoons();
            
            Console.WriteLine("|                                                                    |\n" + "|                                                                    |");
            Console.WriteLine("----------------------------------------------------------------------");
            return total;
        }
    }
}
