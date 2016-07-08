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
                Console.WriteLine("Oxygen Present {0} is habitable",Name);
                return true;
                
            }
            else
            {
                Console.WriteLine("Oxygen absent {0} is not habitable",Name);
                return false;
            }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // OVERRIDE ToString METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("planet {0} has a diameter of {1} with mass {2},a rotation period of {3} years and an orbital period of {4} ", Name, Diameter, Mass,RotationalPeriod,OrbitalPeriod);
            Habitable();
            return total;
        }
    }
}
