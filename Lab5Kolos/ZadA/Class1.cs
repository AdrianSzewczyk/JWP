namespace Generyki
{
    public interface IPoprawialny<T>
    {
        T PobierzLepsząWersję();
    }
    public class Student : IComparable<Student>, IPoprawialny<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }

        public Student(string nazwisko, double ocena)
        {
            Nazwisko = nazwisko;
            Ocena = ocena;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Ocena.CompareTo(other.Ocena);
        }

        public Student PobierzLepsząWersję()
        {
            double nowaOcena = Math.Min(Ocena + 0.5, 5.0);
            return new Student(Nazwisko, nowaOcena);
        }

        public override string ToString()
        {
            return $"{Nazwisko} ({Ocena})";
        }
    }


public static class Narzedzia
    {
        public static T ZnajdźWiększy<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) >= 0)
                return a;
            else
                return b;
        }
    }
    public class Samochód : IPoprawialny<Samochód>
    {
        public string Marka { get; set; }
        public int RokProdukcji { get; set; }

        public Samochód(string marka, int rok)
        {
            Marka = marka;
            RokProdukcji = rok;
        }

        public Samochód PobierzLepsząWersję()
        {
            // Ulepszenie: "odmłodzenie" auta o 1 rok (ale max 2024)
            int nowyRok = Math.Min(RokProdukcji + 1, 2024);
            return new Samochód(Marka, nowyRok);
        }

        public override string ToString()
        {
            return $"{Marka} ({RokProdukcji})";
        }
    }

}
