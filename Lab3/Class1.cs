using System;
using System.Diagnostics;

namespace Motoryzacja
{
    public class Pojazd
    {
        public int Lp { get; private set; } // Liczba porządkowa (unikalna dla każdego pojazdu)
        private static int liczbaPojazdow; // Statyczna liczba pojazdów

        public string Nazwa { get; set; } = "";

        private int ileKół;
        public int IleKół
        {
            get { return ileKół; }
            set
            {
                if (value < 0) throw new ArgumentException("Błędna Wartość Kół");
                ileKół = value;
            }
        }

        private double prędkość;
        public double Prędkość
        {
            get { return prędkość; }
            set
            {
                if (value < 0) throw new ArgumentException("Błędna Prędkość");
                prędkość = value;
            }
        }

        // *** Statyczny konstruktor inicjalizujący liczbaPojazdow ***
        static Pojazd()
        {
            liczbaPojazdow = 0; // Inicjalizacja statycznego pola
        }

        // *** Konstruktor bezparametrowy ***
        public Pojazd()
        {
            liczbaPojazdow++; // Zwiększanie liczby pojazdów
            Lp = liczbaPojazdow; // Ustawienie liczby porządkowej
        }

        // *** Konstruktor główny (oparty na bezparametrowym) ***
        public Pojazd(string n, int i, double p) : this()
        {
            Nazwa = n;
            IleKół = i;
            Prędkość = p;
        }

        // *** Konstruktor z domyślną liczbą kół (oparty na głównym) ***
        public Pojazd(string n, double p) : this(n, 4, p) { }

        // *** Nadpisanie ToString() ***
        public override string ToString()
        {
            return $"Lp: {Lp}, {Nazwa}, {IleKół} kół, {Prędkość} km/h, {Lp}/{liczbaPojazdow}";
        }
    }

    public class PojazdMechaniczny : Pojazd
    {
        private double mocSilnika;
        public double MocSilnika
        {
            get { return mocSilnika; }
            set
            {
                if (value < 0) throw new ArgumentException("Błędna Moc Silnika");
                mocSilnika = value;
            }
        }
        public PojazdMechaniczny(string n, int i, double p,double m) : base(n, i, p)
        {
            MocSilnika = m;
        }
        public override string ToString()
        {
            return base.ToString() + $", Moc:{MocSilnika} KM";
        }

    }
    public class Samochód : Pojazd
    {
        public string Marka { get; set; }
        private int liczbaPasażerów;
        public int LiczbaPasażerów
        {
            get { return liczbaPasażerów; }
            set
            {
                if (value < 0) throw new ArgumentException("Błędna Moc Silnika");
                liczbaPasażerów = value;
            }
        }
        public Samochód(string n, int i, double p, int lp,string marka) : base(n, i, p)
        {
            LiczbaPasażerów = lp;
            Marka = marka;
        }
        public override string ToString()
        {
            return base.ToString() + $", Marka:{Marka},  liczba pasażerów: {LiczbaPasażerów}";
        }


    }
}

