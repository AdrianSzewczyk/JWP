namespace Geometria
{
    public abstract class Bryła
    {
        public abstract string Nazwa { get; }

        // Właściwości gęstości i ceny, które są ustawiane przez konstruktor
        public double Gęstość { get; set; }
        public double CenaZaKg { get; set; }

        // Zmiana metod na właściwości tylko do odczytu
        public double Masa => Gęstość * ObliczObjętość;  // Właściwość tylko do odczytu
        public double ObliczCenę => CenaZaKg * Masa;    // Właściwość tylko do odczytu

        // Abstrakcyjna właściwość dla objętości
        public abstract double ObliczObjętość { get; }

        // Konstruktor klasy bazowej
        public Bryła(double g, double c)
        {
            Gęstość = g;
            CenaZaKg = c;
        }

        // Nadpisanie metody ToString
        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Gęstość: {Gęstość:F2}, Cena za KG: {CenaZaKg:F2}, Objętość: {ObliczObjętość:F2}, Masa: {Masa:F2}, Cena: {ObliczCenę:F2}";
        }
    }

    public class Kula : Bryła
    {
        public double Promień { get; set; }

        // Nadpisanie właściwości Nazwa
        public override string Nazwa => "Kula";

        // Nadpisanie właściwości ObliczObjętość, oblicza objętość kuli
        public override double ObliczObjętość => 4.0 / 3.0 * Math.PI * Math.Pow(Promień, 3);

        // Konstruktor klasy Kula
        public Kula(double g, double c, double pr) : base(g, c)
        {
            Promień = pr;
        }
        public static Kula operator +(Kula kula1, Kula kula2)
        {
            double nowaObjętość = kula1.ObliczObjętość + kula2.ObliczObjętość;
            // Zakładamy, że promień nowej kuli to pierwiastek sześcienny z nowej objętości
            double nowyPromień = Math.Pow((3.0 / 4.0 * nowaObjętość / Math.PI), 1.0 / 3.0);
            return new Kula(kula1.Gęstość, kula1.CenaZaKg, nowyPromień);
        }

        // Przeciążenie operatora - (odejmowanie objętości dwóch kul)
        public static Kula operator -(Kula kula1, Kula kula2)
        {
            double nowaObjętość = kula1.ObliczObjętość - kula2.ObliczObjętość;
            if (nowaObjętość < 0) nowaObjętość = 0; // Zabezpieczenie przed ujemną objętością
            double nowyPromień = Math.Pow((3.0 / 4.0 * nowaObjętość / Math.PI), 1.0 / 3.0);
            return new Kula(kula1.Gęstość, kula1.CenaZaKg, nowyPromień);
        }

        // Przeciążenie operatora ++ (zwiększa objętość kuli o 1 jednostkę)
        public static Kula operator ++(Kula kula)
        {
            double nowaObjętość = kula.ObliczObjętość + 1.0; // Zwiększamy objętość o 1 jednostkę
            double nowyPromień = Math.Pow((3.0 / 4.0 * nowaObjętość / Math.PI), 1.0 / 3.0);
            kula.Promień = nowyPromień; // Aktualizujemy promień kuli
            return kula;
        }
    }
}
