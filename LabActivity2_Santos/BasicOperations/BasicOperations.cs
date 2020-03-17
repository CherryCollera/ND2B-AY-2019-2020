using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Enter first number:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = {0}  ", num1 + num2);
            Console.WriteLine("Difference = {0}  ", num1 - num2);
            Console.WriteLine("Product = {0}  ", num1 * num2);
            Console.WriteLine("Quotient = {0: 0.0}  ", num1 / num2);
            Console.WriteLine("Remainder = {0: 0.}  ", num1 % num2);
            Console.ReadLine();
        }
    }
}
