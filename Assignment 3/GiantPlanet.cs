using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
     class  GiantPlanet : Planet
    {
        private string _type;

        public GiantPlanet(string type,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._type = type;
        }

        public void Hasmoons()
        {
            
        }

        public void HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}
