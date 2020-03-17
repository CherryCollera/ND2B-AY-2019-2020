using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeclaringCons
{
    class Declaring
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radius;
            Console.Write("Enter Radius:  ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Radius: {0: 0.0000}", +radius);
            Console.Write(",  Area: {0: 0.0000}  ", (pi * radius * radius));

            Console.ReadLine();
        }
    }
}
