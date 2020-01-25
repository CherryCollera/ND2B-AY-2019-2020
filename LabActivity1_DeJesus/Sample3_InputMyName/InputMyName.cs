/*18-03092
 * Natazjah De Jesus
 * BSCS-ND2B
 * January 23,2020
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
            Console.WriteLine("Enter Your Name (firstname lastname):");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("Hello," +firstname+ lastname+"!"+"\n"+ "Welcome to the OOP environment.");
            Console.ReadKey();
        }
    }
}
