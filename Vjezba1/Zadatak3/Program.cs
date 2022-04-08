/*Napisati program  za  bankare  koji  ima  deklariran  pobrojani  tip  podataka  u  kojem  se nalaze vrste računa 
 * (Štednja , Tekući račun, Žiro račun). Unutar programa deklarirati strukturu BankAccount koja će sadržavati tri varijable,
 * broj računa, iznos na računu i vrstu računa. Program  treba  deklarirati  polje  struktura  BankAccount  od  5  elemenata, 
 * te  napraviti izbornik  koji će  imati  opcije, upisa  novog  računa, i  ispis  svih  računa.  
 * Za  ispis  svih računa koristiti “foreach” iteraciju.*/

using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace zad3
{
    class Program
    {
        enum vrste
        {
            Štednja,
            TekućiRačun,
            ŽiroRačun
        }

        struct BankAccount
        {
            int brRacuna;
            double iznos;
            string vrstaRacuna;
            public BankAccount(int a, double b, vrste c)
            {
                this.brRacuna = a;
                this.iznos = b;
                this.vrstaRacuna = c.ToString();
            }
            public string toString()
            {
                return "Broj Računa: " + brRacuna.ToString() + "  " + "Iznos Računa: " + iznos.ToString() + "  " + "Vrsta Računa: " + vrstaRacuna + "\n";
            }

        }
        static void Main(string[] args)
        {
            Collection<BankAccount> racuni = new Collection<BankAccount>();
            string input = "1";
            for (int i = 0; i < 5; i++)
            {
                racuni.Add(new BankAccount(10000000 + i, i * 100, (vrste)(i % 2)));
            }
            int br = 5;
            while (input == "1" || input == "2")
            {
                Console.WriteLine(" I Z B O R N I K \n\n Novi račun...............[1] \n\n Ispis svih računa........[2] \n\n");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Odaberite tip računa.... \n Štednja [1]\n Tekući račun [2]\n Žiro račun [3]");
                    int v = int.Parse(Console.ReadLine());

                    BankAccount racun = new BankAccount(10000000 + br, 0, (vrste)(v - 1));
                    racuni.Add(racun);
                    Console.WriteLine(racun.toString());
                    br++;

                }
                if (input == "2")
                {
                    foreach (BankAccount racun in racuni)
                        Console.WriteLine(racun.toString());
                }
            }
        }
    }
}

