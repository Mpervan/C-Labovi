using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Collections;
using System.Collections.ObjectModel;

namespace Vjezba3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int Brojac = 0;
        static Collection<Uplatnica> Transakcije = new Collection<Uplatnica>();
        public MainWindow()
        {
            InitializeComponent();
        }
        static bool Hitno;
        private void HitnoBox_Checked(object sender, RoutedEventArgs e)
        {
            Hitno = true;
        }
        private void Uplati_Botun_Klik(object sender, RoutedEventArgs e)
        {
            if (Platitelj_Ime.Text == "" || Valuta.Text == "" || IznosTekst.Text == "" || IBANPlatitelj.Text == "" || ModelPlatitelj.Text == "" || PrimateljIme.Text == "" || PrimateljIBAN.Text == "" || PrimateljModel.Text == "")
            {
                MessageBox.Show("Unesite podatke prije spremanja!", "Greška!");
                return;
            }
            double Test;
            if (double.TryParse(IznosTekst.Text,out Test) == false)
            {
                MessageBox.Show("Novčani iznos nije broj!", "Greška!");
                return;
            }
            if(IBANPlatitelj.Text == PrimateljIBAN.Text)
            {
                MessageBox.Show("IBAN platitelja je identičan IBAN-u primatelja.", "Greška!");
                return;
            }

            Uplatnica Nova = new Uplatnica(Platitelj_Ime.Text, Valuta.Text, double.Parse(IznosTekst.Text), ModelPlatitelj.Text, PNBPlatitelj.Text, IBANPlatitelj.Text, PrimateljIme.Text, PrimateljModel.Text, PrimateljPNB.Text, PrimateljIBAN.Text, Hitno);
            if (Nova.Provjere() == false)
            {
                MessageBox.Show("Jedan ili više podataka je unešeno \nu neispravnom formatu! \n \n....Pokušajte ponovno!....", "Greška!");
                return;
            }
            if (Nova.Provjere() == true)
            {
                Brojac += 1;
                Nova.Broj = Brojac;
                Transakcije.Add(Nova);
                MessageBox.Show("Uplatili ste: " + IznosTekst.Text + Valuta.Text + "\nsa računa pod IBAN-om: " + IBANPlatitelj.Text + "\nna račun pod IBAN-om: " + PrimateljIBAN.Text, "Transakcija uspješna");
                IznosTekst.Clear();

            }
        }

        private void Pronadi_IBAN(object sender, RoutedEventArgs e)
        {
            foreach(Uplatnica P in Transakcije)
            {
                P.PretraziIBAN(IBANPlatitelj.Text);
            }
            
        }

        private void Pronadi_Ime(object sender, RoutedEventArgs e)
        {
            foreach (Uplatnica P in Transakcije)
            {
                P.PretraziIme(Platitelj_Ime.Text);
            }
        }
    }
}
