namespace Motoryzacja
{
    public class Pojazd
    {
        public string Nazwa { get; set; } = "";
        private int liczbaKół;
        public int IleKół
        {
            get { return liczbaKół; }
            set
            {
                if (value < 0) value = 0;
                this.liczbaKół = value;
            }
        }

        private double prędkość;
        public double Prędkość
        {
            get { return prędkość; }
            set
            {
                if (value < 0) throw new ArgumentException();
                this.prędkość = value;
            }
        }

        
        private static short liczbaPojazdów;

        
        public short Lp { get; private set; }

        
        static Pojazd()
        {
            liczbaPojazdów = 0; 
        }

        
        public Pojazd()
        {
            liczbaPojazdów++; 
            Lp = liczbaPojazdów; 
        }

        
        public Pojazd(string n, int lk, double pr) : this() 
        {
            Nazwa = n;
            Prędkość = pr;
            IleKół = lk;
        }

        public Pojazd(string n, double pr) : this(n, 4, pr) 
        {
        }

        
        public override string ToString()
        {
            return $"Lp: {Lp}/{liczbaPojazdów}, Nazwa: {Nazwa}, Liczba Kół: {IleKół}, Prędkość: {Prędkość} km/h";
        }
    }
}
