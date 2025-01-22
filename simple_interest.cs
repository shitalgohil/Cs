using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principle amount:");
            double p_amt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter rate of interest:");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number of year:");
            double n = Convert.ToDouble(Console.ReadLine());
            double si = (p_amt * rate * n) / 100;
            Console.WriteLine("simple interest is:" + si);
            Console.ReadLine();
        }
    }
}
