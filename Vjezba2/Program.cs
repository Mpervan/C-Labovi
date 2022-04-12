using System;
using System.Globalization;
using System.Collections;
using System.Collections.ObjectModel;


namespace Vjezba2
{
    class Program
    {

        class Uplatnica
        {
            int Br;
            string Platitelj;
            string Valuta;
            double Iznos;
            string ModelPlatitelj;
            string PozivNaBrojPlatitelja;
            string IBANPlatitelja;
            string Primatelj;
            string ModelPrimatelj;
            string PozivNaBrojPrimatelja;
            string IBANPrimatelja;
            DateTime Datum;
            public Uplatnica(string P, string V, double I, string M1, string PNB1, string IBAN1, string P2, string M2, string PNB2, string IBAN2)
            {
                this.Platitelj = P;
                this.Valuta = V;
                this.Iznos = I;
                this.ModelPlatitelj = M1;
                this.PozivNaBrojPlatitelja = PNB1;
                this.IBANPlatitelja = IBAN1;
                this.Primatelj = P2;
                this.ModelPrimatelj = M2;
                this.PozivNaBrojPrimatelja = PNB2;
                this.IBANPrimatelja = IBAN2;
                this.Datum = DateTime.Now;
            }
            public int Broj
            {
                get
                {
                    return this.Br;
                }
                set
                {
                    this.Br = value;
                }
            }

            public void IspisiUplatnicu() => Console.WriteLine("\n \n Transakcija broj " + Br + " \n Platitelj: " + this.Platitelj + "\n Valuta: " + this.Valuta + " Iznos: " + this.Iznos.ToString() + "\n Model Platitelja: " + this.ModelPlatitelj + "   Poziv na broj: " + this.PozivNaBrojPlatitelja + "\n IBAN: " + this.IBANPlatitelja + "\n Model Primatelja: " + this.ModelPrimatelj + "   Poziv na broj: " + this.PozivNaBrojPrimatelja + "\n IBAN: " + this.IBANPrimatelja + "\n DAtum transakcije: " + Datum.ToString()+ "\n \n");
            public void PretraziIBAN(string IBAN)
            {
                if (this.IBANPlatitelja == IBAN || this.IBANPrimatelja == IBAN)
                    this.IspisiUplatnicu();
            }
            public void PretraziIme(string Ime)
            {
                if (this.Platitelj == Ime || this.Primatelj == Ime)
                    this.IspisiUplatnicu();
            }
            public bool Provjere()
            {
                if (this.ModelPlatitelj.Length != 4 || this.ModelPlatitelj.IndexOf('H') != 0 || this.ModelPlatitelj.IndexOf('R') != 1 || !Char.IsNumber(this.ModelPlatitelj, 2) || !Char.IsNumber(this.ModelPlatitelj, 2))
                    return false;
                if (this.PozivNaBrojPlatitelja.Length > 22)
                    return false;
                if (this.IBANPlatitelja.Length != 21 || this.IBANPlatitelja.IndexOf('H') != 0 || this.IBANPlatitelja.IndexOf('R') != 1)
                    return true;
                if (this.ModelPrimatelj.Length != 4 || this.ModelPrimatelj.IndexOf('H') != 0 || this.ModelPrimatelj.IndexOf('R') != 1 || !Char.IsNumber(this.ModelPrimatelj, 2) || !Char.IsNumber(this.ModelPrimatelj, 2))
                    return false;
                if (this.PozivNaBrojPrimatelja.Length > 22)
                    return false;
                if (this.IBANPrimatelja.Length != 21 || this.IBANPrimatelja.IndexOf('H') != 0 || this.IBANPrimatelja.IndexOf('R') != 1)
                    return false;
                else;
                    return true;

            }
        }


        static int Brojac = 0;
        static Collection<Uplatnica> Transakcije = new Collection<Uplatnica>();
        static void Main(string[] args)
        {
            string Unos = "1";
            string Pretrazivac = new string("");
            while (Unos == "1" || Unos == "2")
            {
                Console.WriteLine("Pretraživać transakcija...... [1] \n Unos nove uplatnice...... [2]");
                Unos = Console.ReadLine();
                if (Unos == "1")
                {
                    Console.WriteLine("Pretraži po IBANu...... [1] \n Pretraži po imenu...... [2]");
                    Unos = Console.ReadLine();
                    if (Unos == "1")
                    {
                        Console.WriteLine("Unesite IBAN: ");
                        Pretrazivac = Console.ReadLine();
                        Console.WriteLine("\n \n Sve transakcije sa IBANom " + Pretrazivac + ":");
                        foreach (Uplatnica P in Transakcije)
                        {
                            P.PretraziIBAN(Pretrazivac);
                        }
                        Console.WriteLine("Pretraži po IBANu...... [1] \n Pretraži po imenu...... [2]");
                        Unos = Console.ReadLine();
                    }
                    if (Unos == "2")
                    {
                        Console.WriteLine("Unesite ime: ");
                        Pretrazivac = Console.ReadLine();
                        Console.WriteLine("Sve transakcije pod imenom " + Pretrazivac + ":");
                        foreach (Uplatnica P in Transakcije)
                        {
                            P.PretraziIme(Pretrazivac);
                        }
                        Console.WriteLine("Pretraži po IBANu...... [1] \n Pretraži po imenu...... [2]");
                        Unos = Console.ReadLine();
                    }
                }
                if (Unos == "2")
                {
                    string Platitelj;
                    string Valuta;
                    double Iznos;
                    string ModelPlatitelj;
                    string PozivNaBrojPlatitelja;
                    string IBANPlatitelja;
                    string Primatelj;
                    string ModelPrimatelj;
                    string PozivNaBrojPrimatelja;
                    string IBANPrimatelja;
                    Console.WriteLine("Ime Platitelja: ");
                    Platitelj = Console.ReadLine();
                    Console.WriteLine("Valuta: ");
                    Valuta = Console.ReadLine();
                    Console.WriteLine("Iznos: ");
                    Iznos = double.Parse(Console.ReadLine());
                    Console.WriteLine("Model Platitelja: ");
                    ModelPlatitelj = Console.ReadLine();
                    Console.WriteLine("Poziv na broj Platitelja: ");
                    PozivNaBrojPlatitelja = Console.ReadLine();
                    Console.WriteLine("IBAN Platitelja: ");
                    IBANPlatitelja = Console.ReadLine();
                    Console.WriteLine("Ime Primatelja: ");
                    Primatelj = Console.ReadLine();
                    Console.WriteLine("Model Primatelja: ");
                    ModelPrimatelj = Console.ReadLine();
                    Console.WriteLine("Poziv na broj Primatelja: ");
                    PozivNaBrojPrimatelja = Console.ReadLine();
                    Console.WriteLine("IBAN Primatelja: ");
                    IBANPrimatelja = Console.ReadLine();

                    Uplatnica Nova = new Uplatnica(Platitelj, Valuta, Iznos, ModelPlatitelj, PozivNaBrojPrimatelja, IBANPlatitelja, Primatelj, ModelPrimatelj, PozivNaBrojPrimatelja, IBANPrimatelja);
                    if(Nova.Provjere() == false)
                        { 
                            Console.WriteLine("\n \n .....Pogrešno unesen format podataka!..... \n ...Molimo vas pokušajte ponovno!..... \n");
                            Console.WriteLine("Ime Platitelja: ");
                            Platitelj = Console.ReadLine();
                            Console.WriteLine("Valuta: ");
                            Valuta = Console.ReadLine();
                            Console.WriteLine("Iznos: ");
                            Iznos = double.Parse(Console.ReadLine());
                            Console.WriteLine("Model Platitelja: ");
                            ModelPlatitelj = Console.ReadLine();
                            Console.WriteLine("Poziv na broj Platitelja: ");
                            PozivNaBrojPlatitelja = Console.ReadLine();
                            Console.WriteLine("IBAN Platitelja: ");
                            IBANPlatitelja = Console.ReadLine();
                            Console.WriteLine("Ime Primatelja: ");
                            Primatelj = Console.ReadLine();
                            Console.WriteLine("Model Primatelja: ");
                            ModelPrimatelj = Console.ReadLine();
                            Console.WriteLine("Poziv na broj Primatelja: ");
                            PozivNaBrojPrimatelja = Console.ReadLine();
                            Console.WriteLine("IBAN Primatelja: ");
                            IBANPrimatelja = Console.ReadLine();
                    }
                    if (Nova.Provjere() == true)
                    {
                        Brojac += 1;
                        Nova.Broj = Brojac;
                        Transakcije.Add(Nova);
                        Nova.IspisiUplatnicu();
                    }
                }

            }
        }
    }
}
