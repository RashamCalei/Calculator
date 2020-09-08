using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class CalculationHistory
    {
        public float firstNumber { get; set; }
        public float secondNumber { get; set; }
        public string stringOperation { get; set; }
        public CalculationHistory(float firstNum, float secondNum, string op)
        {
            firstNumber = firstNum;
            secondNumber = secondNum;
            stringOperation = op;
        }
        public void ShowCalculation()
        {
            System.Console.WriteLine($"{firstNumber} {stringOperation} {secondNumber} = {calculationResult}");
        }
    }
}
