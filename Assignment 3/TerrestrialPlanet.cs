using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class TerrestrialPlanet : Planet
    {
        private int _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass) : base(name, diameter, mass)
        {
        }


        public void Habitable()
        {
            throw new System.NotImplementedException();
        }

        public void HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}
