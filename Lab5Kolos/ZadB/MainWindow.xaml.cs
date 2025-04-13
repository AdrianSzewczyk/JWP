using System.Security.Cryptography;
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
using Generyki;

namespace ZadB;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Dictionary<int, Student> słownik = new Dictionary<int, Student>();
    public MainWindow()
    {   
        słownik.Add(100, new Student("Szewczyk", 5));
        słownik.Add(101, new Student("Wesoły", 5));
        słownik.Add(102, new Student("Pawlik", 5));
        słownik.Add(103, new Student("Adamczyk", 2));
        InitializeComponent();
    }

    private void btnSzukaj_Click(object sender, RoutedEventArgs e)
    {
        bool znaleziono = false;
        foreach (var s in słownik)
        {
            if (s.Key == Convert.ToInt32(txtNumer.Text))
            {
                MessageBox.Show($"Nazwisko {s.Value.Nazwisko}, Ocena {s.Value.Ocena}");
                znaleziono = true;
                break;
            }
        }

        if (!znaleziono)
        {
            MessageBox.Show("Nie znaleziono");
        }

        // TESTY METODY ZnajdźWiększy
        string s1 = "Ala", s2 = "Ola";
        double d1 = 3.5, d2 = 4.5;
        Student st1 = new Student("Kowalski", 4.0);
        Student st2 = new Student("Nowak", 5.0);

        string większyString = Narzedzia.ZnajdźWiększy(s1, s2);
        double większyDouble = Narzedzia.ZnajdźWiększy(d1, d2);
        Student lepszyStudent = Narzedzia.ZnajdźWiększy(st1, st2);

        MessageBox.Show($"Większy string: {większyString}");
        MessageBox.Show($"Większy double: {większyDouble}");
        MessageBox.Show($"Lepszy student: {lepszyStudent}");
    }

    private void btnPopraw_Click(object sender, RoutedEventArgs e)
    {
        Student student = new Student("Kowalski", 4.2);
        Student lepszyStudent = student.PobierzLepsząWersję();

        Samochód auto = new Samochód("Toyota", 2020);
        Samochód lepszeAuto = auto.PobierzLepsząWersję();

        MessageBox.Show($"Student przed: {student}, po: {lepszyStudent}");
        MessageBox.Show($"Samochód przed: {auto}, po: {lepszeAuto}");
    }

}