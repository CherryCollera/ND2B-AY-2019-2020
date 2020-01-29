/*18-05235
 * Raven R. Amisola
 * BSCS-ND2B
 * January 23, 2020
 * This program will display name, date of birth, course, yearand
 * section
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
            Console.WriteLine("Hello" + " " + firstname + lastname +" "+ "Welcome to OOP Environment");

            System.Console.ReadKey();
        }
    }
}
