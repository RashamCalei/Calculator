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
            int i = 0;
            do
            {
                calc.SetFirstValue();
                calc.ChooseSign(reader = System.Console.ReadLine());
                calc.ShowResult();
                History hist = new History(i, calc);
                i++;
                if (reader == "history")
                {
                    hist.ShowHistory();
                }
                while (System.Console.ReadKey().Key != ConsoleKey.Enter) {/*wieczna pętla*/}
                System.Console.Clear();
                if (i == 9) 
                {
                    i = 0;
                }
                if (reader == "stop") break;
            } while (true);
        }
    }
}
