using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace age_checking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 0 && age <= 12)
            {
                Console.WriteLine("You are kid");
            }
            else if (age >= 13 && age <= 17)
            {
                Console.WriteLine("you are teenager");
            }
            else if(age >= 18 && age <= 60)
            {
                Console.WriteLine("you are adult");
            }
            else if(age > 60)
            {
                Console.WriteLine("you are senior citizen");
            }
            else
            {
                Console.WriteLine("enter valid input");
            }
        }
    }
}
