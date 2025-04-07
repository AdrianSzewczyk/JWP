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

namespace ZadanieB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Student> słownik = new Dictionary<int, Student>();
        public MainWindow()
        {
            InitializeComponent();
            słownik.Add(0, new Student("Pawlik",5));
            słownik.Add(1, new Student("Szewczyk", 5));
            słownik.Add(2, new Student("Wesoły", 5));
            słownik.Add(3, new Student("Puk", 2));


        }

        private void btnSzukaj_Click(object sender, RoutedEventArgs e)
        {
            // Pobieranie numeru albumu z TextBox
            int i = Convert.ToInt32(txtIndex.Text);

            // Pętla do iteracji po słowniku
            bool znaleziono = false; // Flaga do sprawdzania, czy znaleziono studenta

            foreach (var s in słownik)
            {
                // Sprawdzanie, czy numer albumu zgadza się z kluczem
                if (s.Key == i)
                {
                    Student student = s.Value; // Pobranie studenta o danym numerze albumu
                    MessageBox.Show($"Nazwisko: {student.Nazwisko}\nOcena: {student.Ocena}");
                    znaleziono = true; // Zmieniamy flagę na true, jeśli znaleziono studenta
                    break; // Kończymy pętlę, bo już znaleźliśmy studenta
                }
            }

            if (!znaleziono)
            {
                MessageBox.Show("Nie znaleziono studenta.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = 1;
            double y = 4;
            double większyDouble = Klasa.ZnajdźWiększy(x, y);
            MessageBox.Show($"Większa liczba z {x} i {y} to: {większyDouble}");

            // Test dla typu string
            string str1 = "apple";
            string str2 = "banana";
            string większyString = Klasa.ZnajdźWiększy(str1, str2);
            MessageBox.Show($"Większy ciąg znaków z \"{str1}\" i \"{str2}\" to: {większyString}");

            // Test dla typu Student
            Student student1 = new Student("Pawlik", 5);
            Student student2 = new Student("Szewczyk", 4);
           // Student większyStudent = Klasa.ZnajdźWiększy(student1, student2);
            //MessageBox.Show($"Student z wyższą oceną: {większyStudent.Nazwisko}, Ocena: {większyStudent.Ocena}");
        }
    }
}