namespace Klasy
{
    public abstract class Bryła
    {
        public abstract string Nazwa { get; }
        public double Gęstość { get; set; }
        public double CenaZaKg { get; set; }
        public double Masa => Gęstość * ObliczObjętość;
        public double ObliczCenę => CenaZaKg * Masa;
        public abstract double ObliczObjętość { get; }

        public Bryła(double g, double c)
        {
            Gęstość = g;
            CenaZaKg = c;
        }
    }

    public delegate void ObsługaBłędu(string opisBłędu);

    public class Stożek : Bryła
    {
        public event ObsługaBłędu Obsługa;

        private double promien;
        public double Promień
        {
            get { return promien; }
            set
            {
                if(Obsługa != null) {
                    if (value < 0)
                        Obsługa($"Błędna Wartość promienia");
                    else
                        promien = value;
                }
                
            }
        }

        private double wysokosc;
        public double Wysokość
        {
            get { return wysokosc; }
            set
            {
                if(Obsługa!=null) {
                    if (value < 0)
                        Obsługa($"Błędna Wartość wysokości");
                    else
                        wysokosc = value;
                }
                
            }
        }

        public override string Nazwa => "Stożek";
        public override double ObliczObjętość => (1.0 / 3.0) * Wysokość * Math.PI * Math.Pow(Promień, 2);

        public Stożek(double g, double c, double pr, double h) : base(g, c)
        {
            Promień = pr;
            Wysokość = h;
        }
    }
}

