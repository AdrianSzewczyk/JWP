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

namespace Zad3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnStworzTablice_Click(object sender, RoutedEventArgs e)
    {
        double[,] tablica =
        {
        { 1.1, 2.22, 3.3 },
        { 4.4, 5.55, 6.6 },
        { 7.7, 8.88, 9.9 },
        { 10.1, 11.2, 12.3 },
        { 13.4, 14.5, 15.6 }
    };

        lbWyswietlaczTablicy.Items.Clear(); // Czyści ListBox

        int wiersze = tablica.GetLength(0);
        int kolumny = tablica.GetLength(1);
        double[] sumaKolumn = new double[kolumny]; // Tablica sum kolumn

        // Wyświetlanie wierszy + sumy wierszy
        for (int i = 0; i < wiersze; i++)
        {
            double sumaWiersza = 0;
            string wiersz = "";

            for (int j = 0; j < kolumny; j++)
            {
                wiersz += string.Format("{0,7:0.0}", tablica[i, j]); // Wyrównanie do prawej, szerokość 7 znaków
                sumaWiersza += tablica[i, j];
                sumaKolumn[j] += tablica[i, j]; // Dodanie do sumy kolumny
            }

            wiersz += string.Format("   [{0,5:0.0}]", sumaWiersza); // Suma wiersza w []
            lbWyswietlaczTablicy.Items.Add(wiersz);
        }

        // Wyświetlanie sumy kolumn na końcu
        string sumaKolumnStr = "SUMA: ";
        for (int j = 0; j < kolumny; j++)
        {
            sumaKolumnStr += string.Format("{0,7:0.0}", sumaKolumn[j]); // Szerokość 7 znaków
        }

        lbWyswietlaczTablicy.Items.Add(sumaKolumnStr);
    }

}