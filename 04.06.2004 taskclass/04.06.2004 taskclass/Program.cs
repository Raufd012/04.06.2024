using _04._06._2004_taskclass.Models;

namespace _04._06._2004_taskclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDivide a = new Calculate();
            Console.WriteLine(a.Divide(1, 5));
        }
    }
}
