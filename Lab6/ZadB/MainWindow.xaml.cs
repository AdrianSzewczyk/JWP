using System.Text;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Towary;

namespace ZadB
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

        private void btnJeden_Click(object sender, RoutedEventArgs e)
        {
            List<Towar> towary = new List<Towar>()
            {
                new Towar { Nazwa = "Toster", Cena = 25, Ilość = 15, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Drukarka", Cena = 299.99, Ilość = 5, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Magnes", Cena = 5.50, Ilość = 100, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Telewizor", Cena = 1599.99, Ilość = 3, KategoriaTowaru = Kategoria.Niedostępny },
                // i więcej jeśli chcesz
            };
            var info = towary.Where(s => s.Ilość > 5).OrderBy(s=>s.Ilość);
            foreach(var s in info)
            {
                MessageBox.Show(s.ToString());
            }
            
        }

        private void btnDwa_Click(object sender, RoutedEventArgs e)
        {
            List<Towar> towary = new List<Towar>()
            {
                new Towar { Nazwa = "Toster", Cena = 25, Ilość = 15, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Drukarka", Cena = 299.99, Ilość = 5, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Magnes", Cena = 5.50, Ilość = 100, KategoriaTowaru = Kategoria.Dostępny },
                new Towar { Nazwa = "Telewizor", Cena = 1599.99, Ilość = 3, KategoriaTowaru = Kategoria.Niedostępny },
                // i więcej jeśli chcesz
            };
            var info = towary.Where(s => s.KategoriaTowaru ==Kategoria.Dostępny);
            foreach (var s in info)
            {
                MessageBox.Show(s.ToString());
            }
        }
    }
}