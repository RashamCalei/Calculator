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
            System.Console.WriteLine("Witaj w programie Kalkulator");
            System.Console.WriteLine("[1] - Standard\n[2] - Matura\n[3] - Wyjście");
        labelMode:;
            System.Console.Write("Podaj tryb kalkulatora:");
            switch (ModeSwitcher())
            {
                case 1:     // Standard
                    {
                        for (int i = 0; i < 10; i++)        // pętla for do operowania na tablicy calc
                        {
                            System.Console.WriteLine("[+] Dodawanie");
                            System.Console.WriteLine("[-] Odejmowanie");
                            System.Console.WriteLine("[*] Mnożenie");
                            System.Console.WriteLine("[/] Dzielenie");
                            System.Console.WriteLine("[H] Historia działań");
                            System.Console.WriteLine("Podaj a\nWybierz operację\nPodaj b");
                            calc[i] = new Calculator();     // utworzenie obiektu do pustej referencji calc[i]
                            calc[i].SetFirstNumber();       // podanie (i ustawienie) wartości pierwszej liczby
                            calc[i].ChooseSign(reader = System.Console.ReadLine());
                            // podanie znaku działania (przypisanie go do pola klasy sign)
                            // odpalenie metody Add() 
                            // podanie (i ustawienie) wartości drugiej liczby
                            // obliczenia i przypisanie wyniku do pola result
                            // zwrócenie wyniku
                            if (reader == "h" || reader == "H") { Calculator.ShowHistory(calc); }
                            calc[i].ShowResult();       // wypisanie działania na ekran celem sprawdzenia czy wszystko zadziałało
                            while (System.Console.ReadKey().Key != ConsoleKey.Enter) {/*wieczna pętla*/}
                            System.Console.Clear();
                            if (i == 9) { i = 0; }
                        } break;
                    }
                case 2:     // Matura
                    { System.Console.WriteLine("Implementacja matury później"); break; }
                case 3:
                    { System.Console.WriteLine("Do widzenia!"); break; }
                default:
                    { goto labelMode; }

            }
        }
        public static int ModeSwitcher()
        {
            int value = 0;
            string msg = "Wprowadź liczbę odpowiadającą swojej akcji.";
            string input = System.Console.ReadLine();
            try
            {
                value = int.Parse(input);
                if (value < 1 || value > 3)
                {
                    System.Console.WriteLine(msg);
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine(msg);
            }
            return value;
        }
    }
}

