using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation_DeGuzman
{
    class Input
    {
        public void InputValues()
        {
            try
            {
                System.Console.Write("Enter first number: \t");
                DeclareVar.num1 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Enter second number: \t");
                DeclareVar.num2 = System.Convert.ToInt32(System.Console.ReadLine());
            }
            
            catch(System.FormatException ex)
            {
                System.Console.Error.WriteLine("Error." + ex.Message);
            }
        }
    }
}
