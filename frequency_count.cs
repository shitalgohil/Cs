using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = { 5, 10, 23, 12, 4, 10, 4, 2, 10, 4, 5, 7, 23 };
            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        num[j] = 0;
                    }
                }
                if (num[i] != 0)
                {
                    Console.WriteLine(num[i] + " is visited: " + count + " times");
                }
            }
            Console.ReadLine();
        }
    }
}
