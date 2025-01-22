using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
