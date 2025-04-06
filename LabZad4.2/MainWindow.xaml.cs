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

namespace ZadanieC;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// 


public interface Iwyswietl
{
    string PobierzIdentyfikator();
}
public static class ListBoxExtensions
{
    public static void Dodaj(this ListBox listBox, Iwyswietl obiekt)
    {
        // Dodajemy identyfikator obiektu do ListBox
        listBox.Items.Add(obiekt.PobierzIdentyfikator());
    }
}
public class Student : Iwyswietl
{
    public string Imię { get; set; }
    public string Nazwisko { get; set; }

    public Student(string imię, string nazwisko)
    {
        Imię = imię;
        Nazwisko = nazwisko;
    }

    // Implementacja PobierzIdentyfikator
    public string PobierzIdentyfikator()
    {
        return $"Student: {Imię} {Nazwisko}";
    }
}


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
   

    private void Dodaj(object sender, RoutedEventArgs e)
    {
        var lista = new List<Iwyswietl>
        {
            new Student("Jan", "Kowalski"),
            new Student("Anna", "Nowak"),
            new Student("Piotr", "Zieliński")

        };
        foreach (var obiekt in lista)
        {
            ListBox1.Dodaj(obiekt); // Korzystamy z metody rozszerzającej
        }
    }
}
