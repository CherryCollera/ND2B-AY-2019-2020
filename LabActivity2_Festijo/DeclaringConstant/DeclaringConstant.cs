﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstant
{
    class DeclaringConstant
    {
        static void Main(string[] args)
        {

            double radius; 
            const double pi = 3.14159;
            Console.Write("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: = {0: 0.0000}, ", + radius);
            Console.Write("Area: = {0: 0.0000} ", pi*radius*radius);

            Console.ReadLine();

        }
    }
}
