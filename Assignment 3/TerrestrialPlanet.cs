using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    interface IHabitable
    {
        bool Habitable();
    }
    class TerrestrialPlanet : Planet , IHasMoons , IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(bool oxygen,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


        public bool Habitable()
        {
            if (_oxygen == true)
            { return true; }
            else
            {
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
    }
}
