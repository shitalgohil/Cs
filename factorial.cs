
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find factorial of a given number.
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result=1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"factorial of {n} is {result}");
        }
    }
}
