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
     * <summary>
     * This is the GiantPlanet class. This class inherits from 
     * the abstract Planet Class and implements IHasRings and IHasMoons
     * interfaces.Its constructor takes values for diameter,name and mass
     * from its base abstract class Planet. with the addition of _type
     * private instance variable which is used to determine the type of 
     * Planet.  
     * </summary>
     * @class GiantPlanet
     * @Constructor GiantPlanet() 
     * @method HasMoons(),HasRings()
     * @override method ToString()
     */ 
    class  GiantPlanet : Planet , IHasRings , IHasmoons
    {
        private string _type;

        public GiantPlanet(string type,string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._type = type;
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
                Console.WriteLine("| {0} has moons orbiting around it                               |",Name);
                return true;
            } 
         else
            {
                Console.WriteLine("| {0} does not have any moons                                    |",Name);
                return false;
            }  
        }
        /**
         * <summary>
         * The HasRings() method used for impleting the IHasRings interface.
         * This method checks if the public property RingCount 
         * is set to 0 or greater. If 0 planet has no moons and
         * viceversa
         * </summary>
         */
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
        /** 
         * this is an overrided ToString method
         * which displays all the properties of
         * the instansiated planet
         */ 
        public override string ToString()
        {
            string total = Name + Diameter + Mass;
            Console.WriteLine("\n| Planet {0} has the following properties:                       |" ,Name);
            Console.WriteLine("| Mass:{0} kg                                       |", Mass);
            Console.WriteLine("| Diameter:{0} km                                                 |", Diameter);
            Console.WriteLine("| Rotational Period : {0} hours                                      |",RotationalPeriod);
            Console.WriteLine("| Orbital Period : {0} years                                       |",OrbitalPeriod);
            HasRings();
            HasMoons();
            Console.WriteLine("|                                                                    |\n"+"|                                                                    |");
            Console.WriteLine("----------------------------------------------------------------------");
            return total;
        }
    }
}
