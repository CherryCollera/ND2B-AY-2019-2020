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
            int num1, num2;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.Write("Enter second number: ");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();


            if (num1 > num2)
                Console.WriteLine(num1 + " is greater than " + num2);

            else if (num1 < num2)
                Console.WriteLine(num1 + " is less than " + num2);

            else
                Console.WriteLine(num1+" is equal to "+num2);
           
            Console.ReadKey();
        }
    }
}
