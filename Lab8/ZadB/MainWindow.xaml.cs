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
using ZadB.Migrations;

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

        private void btnCzytaj_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbUczelnia();
            lstLista.Items.Clear();
            foreach (var student in db.Studenci)
            {
                
                lstLista.Items.Add(student);
            }
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            double ocena = Convert.ToDouble(txtOcena.Text);
            Class1 student = new Class1() {Imię=imie
            ,Nazwisko=nazwisko,Ocena=ocena};
            var db = new DbUczelnia();
            db.Add(student);
            db.SaveChanges();

        }
    }
}