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
using Motoryzacja;

namespace Zad1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            List<Pojazd> pojazdy = new List<Pojazd>
            {
                new Pojazd("Toyota", 4, 200),
                new Pojazd("Honda", 4, 180),
                new Pojazd("Seat Ibiza", 4, 1200),
                new Pojazd("BMW", 4, 220)
            };*/
            Pojazd[] tablica = new Pojazd[] {
                new Pojazd("BMW", 2, 220),
                new Pojazd("Toyota",  200),
                new Pojazd("Honda", 4, 180)

            };
            WyswietlPojazdy(tablica);
        }
        

        void WyswietlPojazdy(Pojazd[] pojazdy)
        {
            foreach (var pojazd in pojazdy)
            {
                string dane = pojazd.ToString();
                lbLista.Items.Add(dane);
            }
        }
    }
}