using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display maximum number from 5
            // numbers inputted by user by using the concept of arrays
            int[] a =new int[5];
            Console.WriteLine("enter 5 values:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }

            }
            Console.WriteLine("maximum number is" + max);
            Console.ReadLine();
        }
    }
}
