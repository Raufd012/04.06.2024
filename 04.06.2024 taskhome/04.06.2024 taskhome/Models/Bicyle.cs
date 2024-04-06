using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06._2024_taskhome.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }
        public Bicycle(string factoryname, string model, string color, double drivetimr, double drivepath, string type) : base(factoryname, model, color, drivetimr, drivepath)
        {
            Type = type;
        }

        public override string DefineNatureHarmness()
        {
            return "none";
        }
    }
}
