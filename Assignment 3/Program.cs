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
     * This is the main driver class of the program
     * it instantiates all the objects from their
     * respective classes
     * </summary>
     * @class Program
     * @method Main(string[]) args:void
     * @method WaitForAnyKey():void
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("Student Name: Shahzaib Malik                  Student ID: 300852792  |");
            Console.WriteLine("_____________________________________________________________________|");
            GiantPlanet jupiter = new GiantPlanet("Gaseous", "Jupiter", 139822, 1896454819784917000000000000.00);
            jupiter.OrbitalPeriod = 11.86;
            jupiter.RotationalPeriod = 9.9;
            jupiter.MoonCount = 0;
            jupiter.RingCount = 4;
            jupiter.ToString();
            TerrestrialPlanet earth = new TerrestrialPlanet(true, "Earth", 12742, 5972454819784917000000000.00);
            earth.OrbitalPeriod = 88;
            earth.RotationalPeriod = 365;
            earth.MoonCount = 1;
            earth.ToString();
            WaitForAnyKey();
        }
        //this method waits for user to enter a key and is very useful for is very useful for running with debugging 
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
