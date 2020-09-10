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
        public void ChooseSign(string _sign)        // wybór operacji na podstawie podanego znaku
        {
            SetSign(_sign);
            if (_sign == "+") { Add(); }
            else if (_sign == "-") { Substract(); }
            // warunek aby nie wyświetlał się komunikat o błędzie przy odpaleniu historii
            else if (_sign == "h" || _sign == "H") { System.Console.WriteLine("Historia ostatnich 10 działań:"); }
            else { System.Console.WriteLine("Niepoprawny znak."); }
        }
        public float Add()
        {       // dodawanie
            SetSecondNumber();
            result = firstNumber + secondNumber;
            return result;      // zwrot wyniku
        }
        public float Substract()
        {       // odejmowanie
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
            string input = System.Console.ReadLine();
            float value = 0;

            try
            {
                    value = float.Parse(input);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Wprowadzono niepoprawną wartość.");
                goto labelParse;
            }
            return value;
        }
        public static void ShowHistory(Calculator[] calcArray)      // wyświetla 10 ostatnich działań 
        {                                                           // pobiera tablice typu Calculator jako argument
            for (int i = 0; i < 10; i++)
            {
                if (calcArray[i] == null) { continue; }
                else { calcArray[i].ShowResult(); }
            }
        }
    }
}
