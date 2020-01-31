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
            double num1, num2;
          
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSum = {0}  ", num1 + num2);
            
            Console.Write("\nDifference = {0}  ", num1 - num2);
          
            Console.Write("\nProduct = {0}  ", num1 * num2);

            Console.Write("\nQoutient = {0:0.00}  ", num1 / num2);
            
            Console.Write("\nRemainder = {0}  ", num1 % num2);
            
            Console.ReadLine();

        }
    }
}
