using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            

            Console.WriteLine("Enter 5 grades: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The average is = {0:0.000}  ", (num1 + num2 + num3 + num4 + num5)/5);
            Console.ReadLine();

        }
    }
}
