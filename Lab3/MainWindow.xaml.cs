using System.Security.Cryptography.Pkcs;
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

namespace Zadanie;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    void WyswietlPojazdy(IEnumerable<Pojazd> pojazdy)
    {
        foreach(var pojazd in pojazdy)
        {
            lbLista.Items.Add(pojazd);
        }
    }

    private void btnZadanieA_Click(object sender, RoutedEventArgs e)
    {
        lbLista.Items.Clear();
        Pojazd[] tablica = new Pojazd[]
        {new Pojazd("Toyota",4,78),
        new Pojazd("Renault",4,80),
        new Pojazd("Seat Ibiza",4,300)
        };
        Samochód sam1 = new Samochód("Samochód", 4, 200, 5, "Seat Ibiza");
        WyswietlPojazdy(tablica);
        lbLista.Items.Add(sam1);
    }
}