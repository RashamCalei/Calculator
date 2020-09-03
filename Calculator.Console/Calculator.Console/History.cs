using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class History
    {
        Calculator[] calcResults = new Calculator[10];
      /*public History()
        {
            calcResults = new Calculator[10];
        }*/
        public History(int i,Calculator _calc)
        {
            calcResults[i] = _calc;
        }
        public void ShowHistory()
        {
            foreach (Calculator calc in calcResults)
            {
                calc.ShowResult();
            }
        }
    }
}
