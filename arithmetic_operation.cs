using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("enter value 1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value 2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter any arithmetic operator:");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                result = n1 + n2;
                Console.WriteLine("Addition is:" + result);
            }
            else if (op == '-')
            {
                result = n2 - n1;
                Console.WriteLine("Substraction is:{0}", result);
            }
            else if (op == '*')
            {
                result = n1 * n2;
                Console.WriteLine("Multiplication is:" + result);
            }
            else if (op == '/')
            {
                result = n1 + n2;
                Console.WriteLine($"Division is:{result}");
            }
            else
            {
                Console.WriteLine("invalid operator");
            }
            Console.ReadLine();
        }
    }
}
