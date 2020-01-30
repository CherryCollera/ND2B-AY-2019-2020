using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation_Garniel
{
    class BasicOperation
    {
        static void Main(string[] args)
        {
            Double num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum = {0} ", num1 + num2);
            Console.WriteLine("Difference = {0} ", num1 - num2);
            Console.WriteLine("Product = {0} ", num1 * num2);
            Console.WriteLine("Quotient = {0: 0.00} ", num1 / num2);
            Console.WriteLine("Remainder = {0: 0.00} ", num1 % num2); 
            Console.ReadLine();
        }
    }
}
