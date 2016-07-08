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
                Console.WriteLine("| {0} has moons orbiting around it                               |",Name);
                return true;
            } 
         else
            {
                Console.WriteLine("| {0} does not have any moons                                    |",Name);
                return false;
            }  
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                Console.WriteLine("| {0} has rings around it                                        |",Name);
                return true;
            }
            else
            {
                Console.WriteLine("| {0} does not have any rings around it                          |",Name);
                return false;
            }
        }
        // OVERRIDE ToString METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("\n| Planet {0} has the following properties:                       |" ,Name);
            Console.WriteLine("| Mass:{0}                                                  |", Mass);
            Console.WriteLine("| Diameter:{0}                                                   |", Diameter);
            Console.WriteLine("| Rotational Period : {0} years                                        |",RotationalPeriod);
            Console.WriteLine("| Orbital Period : {0} years                                           |",OrbitalPeriod);
            HasRings();
            HasMoons();
            Console.WriteLine("|                                                                    |\n"+"|                                                                    |");
            Console.WriteLine("----------------------------------------------------------------------");
            return total;
        }
    }
}
