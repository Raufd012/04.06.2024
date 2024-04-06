using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06._2024_taskhome.Models
{
    internal abstract class Vehicle
    {
        string _name;
        string _model;
        string _color;
        double _drivertime;
        double _drivepath;
        public string Factoryname
        {
            get { return _name; }
            set
            {

                _name = value;

            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public double Drivertime
        {
            get
            {
                return _drivertime;
            }
            set
            {

                _drivertime = value;

            }
        }
        public double Drivepath
        {
            get
            {
                return _drivepath;
            }
            set
            {

                _drivepath = value;

            }
        }

        protected Vehicle(string factoryname, string model, string color, double drivetimr, double drivepath)
        {
            _name = factoryname;
            Model = model;
            Color = color;
            Drivertime = drivetimr;
            Drivepath = drivepath;
        }
        public double AverageSpeed()
        {
            return _drivepath / _drivertime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {_name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Drive Time: {Drivertime} hours");
            Console.WriteLine($"Drive Path: {Drivepath} kilometers");
        }
        public override string ToString()
        {
            return $"{_name} - {Model}";
        }
        public abstract string DefineNatureHarmness();
    }
}
