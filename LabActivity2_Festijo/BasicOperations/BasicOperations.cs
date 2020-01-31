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
            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum = {0: 0.0} ", num1 + num2);
            Console.WriteLine("Differece = {0: 0.0} ", num1 - num2);            
            Console.WriteLine("Product = {0: 0.0} ", num1 * num2);            
            Console.WriteLine("Quotient = {0: 0.0} ", num1 / num2);            
            Console.WriteLine("Remainder = {0: 0.0} ", num1 % num2);
            Console.ReadLine();
        }
    }
}
