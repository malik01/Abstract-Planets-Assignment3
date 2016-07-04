using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    interface IHasMoons
    {
        bool HasMoons();
    }
    interface IHasRings
    {
        bool HasRings();
    }
    class  GiantPlanet : Planet , IHasMoons , IHasRings
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
    }
}
