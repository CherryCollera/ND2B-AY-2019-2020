/*18-04978
 * Roselynne Garniel
 * BSCS-ND2B
 * January 23, 2020
 * This program will display name, date of birth, course, year and section
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3_InputMyName
{
    class InputMyName
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            System.Console.WriteLine("Enter your name (firstname lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            System.Console.WriteLine("Hello" + " " + firstname + lastname + " welcome to OOP environment");
            System.Console.ReadKey();
        }
    }
}
