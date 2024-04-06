using _04._06._2024_taskhome.Models;

namespace _04._06._2024_taskhome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "L200", "Red", 2.2, 20, 8, false);
            Car car2 = new Car("Mercedes", "g63", "black", 6.5, 200, 5, false);


            Bicycle bicycle1 = new Bicycle("Start", "desna", "black", 4.0, 20, "manual");
            Bicycle bicycle2 = new Bicycle("Rambo", "desna", "red", 2.0, 25, "manual");



            Car[] cars = { car1, car2 };
            Bicycle[] bicycles = { bicycle1, bicycle2 };

            foreach (var full in cars)
            {
                full.GetInfo();
            }

            Console.WriteLine(" ");
            foreach (var full in bicycles)
            {
                full.GetInfo();
            }
        }
    }
}
