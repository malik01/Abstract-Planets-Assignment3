using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * author Shahzaib Malik
 * student id 300852792 
 * Course code : COMP123
 */
namespace Assignment_3
{
    /**
     * <summary>This is the TerrestrialPlanet class which inherits from 
     * the abstract calss Planet and implements the IHabitable 
     * and IHasMoons interfaces.Its constructor takes values for 
     * diameter,name and massfrom its base abstract class Planet.
     * With and addition of bool instaance variable oxygen which 
     * determins if the planet is habitable or not.
     * </summary>
     * @class TerrestrialPlanet
     * @Constructor TerrestrialPlanet() 
     * @method HasMoons(),Habitable()
     * @override method ToString()
     */ 
    class TerrestrialPlanet : Planet , IHabitable , IHasmoons 
    {
        // private instance variable+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        public TerrestrialPlanet(bool oxygen,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * The Habitable() method used for impleting the IHabitable interface.
         * This method checks if the private instance oxygen bool variable 
         * is set to true or false. If true planet is habitable and
         * viceversa
         * </summary>
         */
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
        /**
         * <summary>
         * The HasMoons() method used for impleting the IHasMoons interface.
         * This method checks if the public property MoonCount 
         * is set to 0 or greater. If 0 planet has no moons and
         * viceversa
         * </summary>
         */
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
        /** 
         * this is an overrided ToString method
         * which displays all the properties of
         * the instansiated planet
         */
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
