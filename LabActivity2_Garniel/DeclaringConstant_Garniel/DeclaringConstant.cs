using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstant_Garniel
{
    class DeclaringConstant
    {
        static void Main(string[] args)
       {

            const double pi = 3.14159;
            double radius;
            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Radius:{0: 0.0000}, ", + radius);
            Console.Write("Area:{0: 0.0000} ", (pi * radius * radius));
            Console.ReadLine();
        }
    }
}
