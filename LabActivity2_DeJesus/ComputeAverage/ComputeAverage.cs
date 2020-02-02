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
            double grade1, grade2, grade3, grade4, grade5;
            Console.Write("Enter Grade: ");
            grade1 = Convert.ToDouble(Console.ReadLine());
            grade2 = Convert.ToDouble(Console.ReadLine());
            grade3 = Convert.ToDouble(Console.ReadLine());
            grade4 = Convert.ToDouble(Console.ReadLine());
            grade5 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("The Average is = {0:0.00}", ((grade1 + grade2 + grade3 + grade4 + grade5) / 5));
            Console.ReadLine();
        }
    }
}
