/*2. Zadatak
Napisati program koji sadrži dvije varijable, jednu tipa int, a drugu tipa long u koju će biti zapisana najveća moguća vrijednost za tip long. 
*Varijablu tipa long treba pridružiti varijabli tipa int, s tim da se obradi iznimka ako dođe do preljeva (overflow).
*Pomoć: vidjeti “checked” u MSDN*/

using System;

namespace Vjezba1Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite broj: ");
                int a = int.Parse(Console.ReadLine());
                long b = long.MaxValue;
                a += checked((int)b);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("...Overflow Exception...");
            }
        }
    }


}
