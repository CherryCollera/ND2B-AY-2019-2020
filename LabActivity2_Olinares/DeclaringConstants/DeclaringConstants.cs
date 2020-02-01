using System;
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
            double radius, AreaCircle;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            AreaCircle = pi * radius * radius;
            Console.Write("Radius: {0:0.0000} " , radius);
            Console.Write("Area: {0:0.0000} ", AreaCircle);
            Console.ReadLine();

        }
    }
}
