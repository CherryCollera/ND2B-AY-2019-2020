﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radius;

            Console.Write("Enter Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Radius: {0:0.0000}", radius);
            
            Console.Write(" Area: " + pi*radius*radius);
            Console.ReadLine();
        }
    }
}
