﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverage_Garniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, num3, num4, num5;
            Console.WriteLine("Enter 5 grades: ");

            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());
            num5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The average is = {0} ", (num1 + num2 + num3 + num4 + num5) / 5);
            Console.ReadLine();
        }
    }
}
