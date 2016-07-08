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
     * this is the abstract class of the program
     * it has private instance variables and a 
     * planet constructor which takes in the
     * name diameter and mass of the planet
     * </summary>
     * @ constructor Planet()
     */
    abstract class Planet 
    {
        // PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        // PUBLIC CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        // PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // READ-ONLY diameter property
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        // READ-ONLY mass property
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }

            set
            {
                this._moonCount = value;
            }
        }
        //READ-ONLY string Name property
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        public double RotationalPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }
    }
}
