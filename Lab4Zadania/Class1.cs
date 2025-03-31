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
    }
}
