using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_quisim
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.Write("\n" + num1 + " is greater than " + num2 + ".");
            }
            else if (num1 < num2)
            {
                Console.Write(num1 + " is less than " + num2 + ".");
            }
            else
            {
                Console.Write(num1 + " is equal to " + num2 +".");
            }
            Console.ReadLine();
        }
    }
}
