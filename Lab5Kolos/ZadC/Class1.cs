namespace Motoryzacja
{
    public interface IZwiekszany
    {
        void Zmień();
    }

    public interface IZmniejszamy
    {
        void Zmień();
    }

    public class Samochód : IZwiekszany, IZmniejszamy
    {
        public double Prędkość { get; set; }

        // Jawna implementacja interfejsu IZwiekszany
        void IZwiekszany.Zmień()
        {
            Prędkość += 10;
        }

        // Jawna implementacja interfejsu IZmniejszamy
        void IZmniejszamy.Zmień()
        {
            Prędkość -= 5;
        }

        public override string ToString()
        {
            return $"Prędkość samochodu: {Prędkość} km/h";
        }
    }
}

