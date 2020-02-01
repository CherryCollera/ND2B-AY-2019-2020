using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computesum_Quisim
{
    class Computesum_Quisim
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0}", num1 + num2);
            Console.ReadLine();
        }
    }
}
