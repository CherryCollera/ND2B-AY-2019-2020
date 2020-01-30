using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_Garniel
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.Write(num1 + " is greater than " + num2 );
            else if (num1 < num2)
                Console.Write(num2 + " is greater than " + num1 );
            else
                Console.Write(num1 + " is equal to " + num2 );

            Console.ReadLine();
        }
    }
}
