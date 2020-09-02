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
            string reader;
            calc.SetFirstValue();
            calc.ChooseSign(reader = System.Console.ReadLine());
            calc.ShowResult();
        }
    }
}
