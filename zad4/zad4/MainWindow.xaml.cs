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

namespace zad4;

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
        int[][] tablica = new int[3][];
        tablica[0] = new int[6]; // Pierwszy wiersz: 6 elementów
        tablica[1] = new int[5]; // Drugi wiersz: 5 elementów
        tablica[2] = new int[3]; // Trzeci wiersz: 3 elementy

        lbLista.Items.Clear(); // Czyści ListBox przed dodaniem nowych danych

        // Wypełnianie tablicy danymi
        for (int i = 0; i < tablica.Length; i++)
        {
            int suma = 0;
            string wiersz = "";

            for (int j = 0; j < tablica[i].Length; j++)
            {
                tablica[i][j] = j + 2; // Wypełniamy liczbami od 2 wzwyż

                // Jeżeli to PIERWSZY wiersz i OSTATNI element -> ustaw 8
                if (i == 0 && j == tablica[i].Length - 1)
                {
                    tablica[i][j] = 8;
                }

                // Jeżeli to DRUGI wiersz, zwiększamy wszystkie liczby o 1
                if (i == 1)
                {
                    tablica[i][j]++;
                }

                suma += tablica[i][j]; // Dodajemy do sumy wiersza
                wiersz += $"{tablica[i][j],4}"; // Formatowanie szerokości kolumny
            }

            wiersz += $"   [{suma}]"; // Dodanie sumy wiersza w nawiasach kwadratowych
            lbLista.Items.Add(wiersz); // Dodanie wiersza do ListBox
        }
    }

}