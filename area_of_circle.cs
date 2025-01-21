using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius of circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double aoc = 3.14 * radius * radius;
            Console.WriteLine($"area of circle is:{aoc}");
            Console.ReadLine();
        }
    }
}
