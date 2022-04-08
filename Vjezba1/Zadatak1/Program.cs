/*1. Zadatak
Napisati program koji upisuje dva cjelobrojna broja i ispisuje rezultat dijeljenja ta dva broja. 
*Rezultat treba ispisati u sljedećim formatima (Currency, Integer, Scientific, Fixed-point, General, Number, Hexadecimal).
*Prilikom upisa nekog podatka sa tipkovnice, podatak se učitava kao tip string, a ako nam treba tip int moramo ga pretvoriti uz pomoć ugrađenih metoda.
*Pripaziti da se obrade sve iznimke*/

using System;

namespace Vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                var b = int.Parse(Console.ReadLine());
                int r = a / b;

                Console.WriteLine("Currency format: " + r.ToString("c"));
                Console.WriteLine("Integer format: " + r.ToString());
                Console.WriteLine("Scientific format: " + r.ToString("e"));
                Console.WriteLine("Fixed-point format: " + r.ToString("f"));
                Console.WriteLine("General format: " + r.ToString("g"));
                Console.WriteLine("Number format: " + r.ToString("n"));
                Console.WriteLine("Hexadecimal format: " + r.ToString("x"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greška: Krivi format unosa!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Greška: Broj prevelik!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Greška: Djeljenje sa 0!");
            }
        }
    }


}

