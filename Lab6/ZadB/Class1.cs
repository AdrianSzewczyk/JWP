namespace Towary
{
    public enum Kategoria { Dostępny, Niedostępny,Zarezerwowane }

    public class Towar
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilość { get; set; }
        public Kategoria KategoriaTowaru { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Cena: {Cena:F2}, Ilość: {Ilość}, " +
                   $"Kategoria: {KategoriaTowaru}";
        }
    }
}
