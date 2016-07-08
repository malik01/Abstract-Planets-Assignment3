using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    
    class  GiantPlanet : Planet , IHasRings , IHasmoons
    {
        private string _type;

        public GiantPlanet(string type,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._type = type;
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

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("planet {0} has a diameter of {1} and a mass of {2} and is {3}", Name, Diameter, Mass);

            return total;
        }
    }
}
