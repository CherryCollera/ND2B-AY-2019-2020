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
            int first, second;
            Console.Write("Enter First Number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine(first + " is greater than " + second);
                Console.ReadLine();
            }
            else if (first < second)
            {
                Console.WriteLine(first + " is less than " + second);
                Console.ReadLine();
            }

            else {
                Console.WriteLine(first + "is equal to" + second);
                Console.ReadLine();
            }
        }
    }
}
