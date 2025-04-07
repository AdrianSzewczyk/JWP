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
using Klasy;

namespace ZadanieA
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

        public void Info(string n) { MessageBox.Show(n); }
        public void Info2(string n)
        {
            lbLabel.Content = n;
        }
        private void btnStworz_Click(object sender, RoutedEventArgs e)
        {
            double r, h;
            r = Convert.ToDouble(txtPromień.Text);
            h = Convert.ToDouble(txtPromień.Text);
            Stożek s1 = new Stożek(0, 0, 0, 0);
            s1.Wysokość = h;
            s1.Promień = r;
            s1.Obsługa += Info;
            s1.Obsługa += Info2;
            
        }
    }
}