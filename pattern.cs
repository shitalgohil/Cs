using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, a = 1;
            for ( i = 1; i < 5; i++)
            {
                a = (i * (i + 1) / 2);
                for( j = 1; j < i; j++)
                {
                    Console.Write(a-- + " ");
                }
                Console.WriteLine(a-- + " ");
            }
            Console.ReadLine();
        }
    }
}
