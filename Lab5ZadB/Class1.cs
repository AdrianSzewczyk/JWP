namespace Generyki
{
    public class Student : IComparable<Student>
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }

        public Student(string nazwisko, double ocena)
        {
            Nazwisko = nazwisko;
            Ocena = ocena;
        }

        // Implementacja metody CompareTo dla klasy Student
        public int CompareTo(Student other)
        {
            if (other == null) return 1; // Jeśli "other" to null, traktuj bieżący obiekt jako większy

            return Ocena.CompareTo(other.Ocena); // Porównaj oceny studentów
        }
    }
    public static class Klasa
    {
        // Metoda generyczna do porównania dwóch obiektów typu T
        public static T ZnajdźWiększy<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) > 0)
            {
                return a; // a jest większe niż b
            }
            else if (a.CompareTo(b) == 0)
            {
                return a; // a i b są równe, zwróć a
            }
            else
            {
                return b; // b jest większe niż a
            }
        }
    }
}
