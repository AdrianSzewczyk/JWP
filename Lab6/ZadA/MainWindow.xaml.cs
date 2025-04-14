using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Funkcje;

namespace ZadA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLambda_Click(object sender, RoutedEventArgs e)
        {
            // Zakres poszukiwań
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;
            long liczbaLosowan = 1000000000;

            // Lambda funkcji celu
            Func<double, double, double> funkcja = (x, y) => x * x + y * y;

            // Szukanie minimum
            var wynik = Funkcje.Funkcja.ZnajdźMinimumFunkcji2D(minX, maxX, minY, maxY, liczbaLosowan, funkcja);

            lbWynik.Content=$"({wynik.x}, {wynik.y}) = {wynik.wartość}";
        }

    }
}