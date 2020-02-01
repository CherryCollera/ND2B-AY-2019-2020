using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity2_Olinares
{
    class ComputeSum
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0}    ", num1 + num2);
            Console.ReadLine();
        }
    }
}
