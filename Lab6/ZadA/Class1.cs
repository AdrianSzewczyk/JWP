namespace Funkcje
{
    public class Funkcja
    {
        public static (double x, double y, double wartość) ZnajdźMinimumFunkcji2D(double minX,
        double maxX,double minY, double maxY,long liczbaLosow, Func<double,double,double> funkcja)
        {
            double? bestX = null, bestY = null, bestWartosc = null;
            Random random = new Random(); 
            for(int i=0; i<liczbaLosow; i++)
            {
                double x=random.NextDouble()*(maxX-minX)+minX;
                double y=random.NextDouble()*(maxY-minY)+minY;
                double wartosc = funkcja(x, y);
                if (y < bestY || bestY==null)
                {
                    bestY = y;
                    bestX = x;
                    bestWartosc = wartosc;

                }
                
            }

            return ((double)bestX, (double)bestY, (double)bestWartosc);
        }
    }
}
