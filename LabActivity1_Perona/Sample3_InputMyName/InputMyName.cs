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
            Console.WriteLine("Input your name (firstname lastname)");
            

            firstname = Console.ReadLine();
            lastname = Console.ReadLine();

            Console.WriteLine("Hello! "+ firstname +" "+ lastname + " welcome to OOP Environment. ENJOYYY!!");
            Console.ReadKey();
        }
    }
}
