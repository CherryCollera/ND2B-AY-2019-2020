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
            int num1, num2, num3, num4, num5, sum;
            double average;
            Console.WriteLine("Enter 5 Grades: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3 + num4 + num5;
            average = sum / 5;
            Console.WriteLine("The average is  = {0 : 0.000}    ", average );
            Console.ReadLine();
        }
    }
}
