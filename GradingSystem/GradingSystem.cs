using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class GradingSystem
    {
        private static object srade;

        static void Main(string[] args)
        {
            double grade;
            String sgrade;

            try
            {

                Console.Write("Enter your final grade: ");
                sgrade = Console.ReadLine();

                if (sgrade.Equals("inc") || sgrade.Equals("INC") || sgrade.Equals("Inc"))
                {
                    Console.WriteLine("Grade Equivalent      : INCOMPLETE");
                    Console.WriteLine("Remarks               : INCOMPLETE");
                }

                else
                {
                    grade = Convert.ToDouble(sgrade);

                    
                    if (grade >= 98 && grade <=100)
                    {
                        Console.WriteLine("Grade Equivalent      : 1.00");
                        Console.WriteLine("Remarks               : Excellent");
                    }
                    else if (grade >= 95 && grade <= 97)
                    {
                        Console.WriteLine("Grade Equivalent      : 1.25");
                        Console.WriteLine("Remarks               : Verry Good");
                    }
                    else if (grade >= 92 && grade <= 94)
                    {
                        Console.WriteLine("Grade Equivalent      : 1.50");
                        Console.WriteLine("Remarks               : Verry Good");
                    }
                    else if (grade >= 89 && grade <= 91)
                    {
                        Console.WriteLine("Grade Equivalent      : 1.75");
                        Console.WriteLine("Remarks               : Verry Good");
                    }
                    else if (grade >= 85 && grade <= 88)
                    {
                        Console.WriteLine("Grade Equivalent      : 2.00");
                        Console.WriteLine("Remarks               : Good");
                    }
                    else if (grade >= 83 && grade <= 84)
                    {
                        Console.WriteLine("Grade Equivalent      : 2.25");
                        Console.WriteLine("Remarks               : Good");
                    }
                    else if (grade >= 80 && grade <=82)
                    {
                        Console.WriteLine("Grade Equivalent      : 2.50");
                        Console.WriteLine("Remarks               : Fair");
                    }
                    else if (grade >= 77 && grade <= 79)
                    {
                        Console.WriteLine("Grade Equivalent      : 2.75");
                        Console.WriteLine("Remarks               : Passed");
                    }
                    else if (grade >= 75 && grade <= 76)
                    {
                        Console.WriteLine("Grade Equivalent      : 3.00");
                        Console.WriteLine("Remarks               : Passed");
                    }
                    else if (grade >= 72 && grade <= 74)
                    {
                        Console.WriteLine("Grade Equivalent      : 4.00");
                        Console.WriteLine("Remarks               : Conditional (MT only)");
                    }
                    else if (grade >= 60 && grade <= 71)
                    {
                        Console.WriteLine("Grade Equivalent      : 5.00");
                        Console.WriteLine("Remarks               : Failed");
                    }

                }

            }

            catch(FormatException error)
            {
                Console.WriteLine(error.Message);
               
            }

            Console.ReadKey();

        }
    }
}
