﻿using System;
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
            // warunek aby nie wyświetlał się komunikat o błędzie przy odpaleniu historii
            if (_sign == "h" || _sign == "H") { System.Console.WriteLine("Historia ostatnich 10 działań:"); }
            else if (_sign == "+") { Add(); }
            else if (_sign == "-") { Substract(); }
            else if (_sign == "*") { Multiply(); }
            else if (_sign == "/") { Divide(); }
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

        public float Multiply()
        {       // mnożenie
            SetSecondNumber();
            result = firstNumber * secondNumber;
            return result;
        }
        public float Divide()
        {       // dzielenie
            SetSecondNumber();
            result = firstNumber / secondNumber;
            return result;
        }
        public void ShowResult()        // wyświetla wynik na ekran      
        {
            System.Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");
        }
        public static void ShowHistory(Calculator[] calcArray)      // wyświetla 10 ostatnich działań 
        {                                                           // pobiera tablice typu Calculator jako argument
            for (int i = 0; i < 10; i++)
            {
                if (calcArray[i] == null) { continue; }
                else if (calcArray[i].sign == "h" || calcArray[i].sign == "H") { continue; }        // wywala obiekt z wywołania metody ShowHistory() już nie zaśmieca ekranu
                else { calcArray[i].ShowResult(); }
            }
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
    }
}
