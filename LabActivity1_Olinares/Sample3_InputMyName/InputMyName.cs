/*18-01554
 * Elaine M. Olinares
 * BSCS-ND2B
 * January 23, 2010
 * This Program will display name, date of birth, course, year and section
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            Console.WriteLine("Enter your name (first name, last name)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello"+ "!!! " + firstname + " " + lastname + " Welcome to OOP environment" );
            Console.ReadKey();
        }
    }
}
