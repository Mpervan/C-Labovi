using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;

namespace Vjezba3
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
        bool Hitno;
        DateTime Datum;
        public Uplatnica(string P, string V, double I, string M1, string PNB1, string IBAN1, string P2, string M2, string PNB2, string IBAN2, bool H)
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

        public void IspisiUplatnicu()
        {
            MessageBox.Show("\n \n Transakcija broj " + Br + " \n Platitelj: " + this.Platitelj + "\n Valuta: " + this.Valuta + " Iznos: " + this.Iznos.ToString() + "\n Model Platitelja: " + this.ModelPlatitelj + "   Poziv na broj: " + this.PozivNaBrojPlatitelja + "\n IBAN: " + this.IBANPlatitelja + "\n Model Primatelja: " + this.ModelPrimatelj + "   Poziv na broj: " + this.PozivNaBrojPrimatelja + "\n IBAN: " + this.IBANPrimatelja + "\n DAtum transakcije: " + Datum.ToString() + "\n \n");
        }
            
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
}
