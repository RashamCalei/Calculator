using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class Calculator
    {       
        float firstValue;       // tworzenie pól klasy
        float secondValue;
        float result;
        public float Add(float a, float b)      // dodawanie // argumenty do wprowadzenia przez użytkownika      
        {
            SetFirstValue(a);        // zapisanie podanych wartości w polach obiektu
            SetSecondValue(b);    
            result = a + b;     
            return result;      // zwrot wyniku
        }
        public float Substract(float a, float b)        // odejmowanie
        {
            SetFirstValue(a);       
            SetSecondValue(b);
            result = a - b;
            return result;
        }
        public float Multiply(float a, float b)     // mnożenie
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
        }
        public void SetFirstValue( float value)     // ustawienie wartości pola firstValue
        {
            this.firstValue = value;
        }
        public void SetSecondValue(float value)     // ustawienie wartości pola secondValue
        {
            this.secondValue = value;
        }
        public void ShowResult()        // z góry ustawiony znak działania nie da rady
        {
            System.Console.WriteLine($"{firstValue} + {secondValue} = {result}");
        }
    }
}
