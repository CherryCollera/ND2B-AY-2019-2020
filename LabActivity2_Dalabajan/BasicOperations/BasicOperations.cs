using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double num3, num4;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1;
            num4 = num2;

            Console.WriteLine("Sum = {0}. ", num1 + num2);

            Console.WriteLine("Diffence = {0}. ", num1 - num2);

            Console.WriteLine("Product = {0}. ", num1 * num2);

            Console.WriteLine("Qoutient = {0}. ", num1 / num2);

            Console.WriteLine("Remainder = {0}. ", num3 % num4);
            Console.ReadKey();




        }
    }
}
