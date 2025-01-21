using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, n2 = 1, n3=1;
            Console.WriteLine(n);
            Console.WriteLine(n2);
            for (int i = 0; i < 5; i++)
            {
                n3 = n + n2;
                n = n2;
                n2 = n3; 
                Console.WriteLine(n3);
            }
        }
    }
}
