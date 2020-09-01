using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class MainClass
    {
        public static void Main()
        {
            Calculator calc = new Calculator();
            calc.Add(Parser(), Parser());
            calc.ShowResult();
            calc.Substract(Parser(), Parser());
            calc.ShowResult();
            calc.Multiply(Parser(), Parser());
            calc.ShowResult();
            calc.Divide(Parser(), Parser());
            calc.ShowResult();
        }
        public static float Parser()
        {
            labelParse:;
            string input;
            float number = 0;
        
            try
            {
                input = System.Console.ReadLine();
                number = float.Parse(input);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Wprowadzono niepoprawną wartość.");
                goto labelParse;
            }
            return number;
        }
    }
}
