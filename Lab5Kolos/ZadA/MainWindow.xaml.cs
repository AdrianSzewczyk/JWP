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

namespace ZadA;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public delegate void ObsługaBłędu(string opisBłedu);
    public class Stożek
    {
        public event ObsługaBłędu Obsługa;
        private double promień;
        public double Promień
        {
            set {
                
                if (value <= 0) Obsługa($"Błedna wartość promienia");
                else
                {
                    promień = value;
                }
            }
            get
            {
                return promień;
            }
        
        }
        private double wysokość;
        public double Wysokość
        {
            set
            {
                if (value <= 0) Obsługa($"Błedna wartość wysokości");
                else  wysokość=value;
            }
            get
            {
                return wysokość;
            }

        }
        
    }
    public void Informacja(string n)
    {
        MessageBox.Show(n);
    }
    public void InformacjaLabel(string n)
    {
        lblWynik.Content = n;

    }


    private void btnPrześlij_Click(object sender, RoutedEventArgs e)
    {
        Stożek s = new Stożek();
        s.Obsługa += Informacja;
        s.Obsługa += InformacjaLabel;
        s.Promień = Convert.ToDouble(txtPromień.Text);
        s.Wysokość = Convert.ToDouble(txtWysokość.Text);


    }
}