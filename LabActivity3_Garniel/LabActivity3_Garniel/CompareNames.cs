﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity3_Garniel
{
    class CompareNames
    {
        static void Main(string[] args)
        {
            string string1 = "Jois";
            string string2 = "Jois";
            string string3 = "Joisse";
            string string4 = "joisse";
            string string5 = "JOISSE";

            Console.WriteLine("Using Equals() method");

            Console.WriteLine(" compare {0} to {1}: {2}",string1, string2, String.Equals(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Equals(string1, string3));
            Console.WriteLine("Length of {0} is {1} ", string1, string1.Length);
            Console.WriteLine("String {0} Substring(0, 3) will return {1}", string5, string5.Substring(0, 3));

            Console.WriteLine("Using Compare() method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, String.Compare(string1, string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, String.Compare(string1, string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, String.Compare(string3, string1));
            Console.WriteLine(" compare {0} to {1}: {2}", string4, string5, String.Equals(string4, string5));

            Console.WriteLine("Using CompareTo() method");
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string2, string1.CompareTo(string2));
            Console.WriteLine(" compare {0} to {1}: {2}", string1, string3, string1.CompareTo(string3));
            Console.WriteLine(" compare {0} to {1}: {2}", string3, string1, string3.CompareTo(string1));

            Console.ReadKey();


        }
    }
}
