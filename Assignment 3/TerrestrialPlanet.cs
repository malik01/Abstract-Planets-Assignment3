﻿using System;
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
                Console.WriteLine(" {0} is habitable",Name);
                return true;
                
            }
            else
            {
                Console.WriteLine(" {0} is not habitable",Name);
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
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("planet {0} has a diameter of {1} and a mass of {2} ", Name, Diameter, Mass);
            Habitable();
            return total;
        }
    }
}
