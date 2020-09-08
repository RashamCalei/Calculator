using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class Calculator
    {       

        float firstNumber;       // tworzenie pól klasy
        float secondNumber;
        float result;
        string sign;
        public void SetFirstNumber()     // ustawienie wartości pola firstValue
        {
            firstNumber = Parser();
        }
        public void SetSecondNumber()     // ustawienie wartości pola secondValue
        {
            secondNumber = Parser();
        }
        public void SetSign(string _sign)
        {
            this.sign = _sign;
        }
        public void ChooseSign(string _sign)
        {
            SetSign(_sign);
            if (_sign == "+")
            {
                Add();
            }
            else if (_sign == "-")
            {
                Substract();
            }
            else
                System.Console.WriteLine("Fuck you");
        }
        public float Add()      // dodawanie      
        {       // TEST //
            SetSecondNumber();
            result = firstNumber + secondNumber;         
            return result;      // zwrot wyniku
        }
        public float Substract()      // odejmowanie      
        {       // TEST2//
            SetSecondNumber();
            result = firstNumber - secondNumber;
            return result; 
        }

        /*  public float Multiply(float a, float b)     // mnożenie
            {
                SetFirstValue(a);       
                SetSecondValue(b);
                result = a * b;
                return result;
            }
            public float Divide(float a, float b)       // dzielenie
            {
                SetFirstValue(a);        
                SetSecondValue(b);
                result = a / b;
                return result;
            }*/
        public void ShowResult()        // wyświetla wynik na ekran      
        {
            System.Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");
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
