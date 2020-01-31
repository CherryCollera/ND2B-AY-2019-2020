using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class IfElse
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            

            if (num1 > num2)
                Console.WriteLine(num1 + " is greater than " + num2);
            else if (num1 < num2)
                Console.WriteLine(num1 + " is less than " + num2);
            else
                
            Console.WriteLine(num1 + " is equal to " + num2);
            Console.ReadKey();
        }
    }
}
