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
            Calculator[] calc = new Calculator[10];     // utworzenie tablicy 10-elementowej typu Calculator
            string reader;      // zmienna pomocnicza do wczytywania danych z klawiatury
            for (int i = 0; i < 10; i++)        // pętla for do operowania na tablicy calc
            {
                calc[i] = new Calculator();     // utworzenie obiektu do pustej referencji calc[i]
                calc[i].SetFirstNumber();       // 
                calc[i].ChooseSign(reader = System.Console.ReadLine());
                calc[i].ShowResult();

                while (System.Console.ReadKey().Key != ConsoleKey.Enter) {/*wieczna pętla*/}
                System.Console.Clear();
                if (i == 9)
                {
                    i = 0;
                }
                if (reader == "stop") break;
            }
        }
    }
}
