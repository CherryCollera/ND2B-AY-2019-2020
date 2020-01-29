/*18-03322
 * Dhariel M. Gigante
 * BSCS-ND2B
 * January 23,2020
 * This Program will display name, date of birth, course, year and section
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
            Console.WriteLine("Enter your name (firstname lastname)");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello" + " " + firstname+ " " + lastname +" " + "Welcome to OOP Environment!");
            Console.ReadKey();
        }
    }
}
