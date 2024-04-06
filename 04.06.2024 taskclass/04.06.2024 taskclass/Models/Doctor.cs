using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06._2024_taskclass.Models
{
    internal class Doctor : Employe
    {
        public Doctor(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public void Heal(Person person)
        {
            Console.WriteLine("Healed");

        }

    }
}
