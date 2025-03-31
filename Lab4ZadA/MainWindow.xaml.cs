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

namespace ZadA
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            DaneWejścioweOkno okno = new DaneWejścioweOkno();
            okno.ShowDialog();
            double w, h, P, O;

            w = okno.Szerokość;
            h = okno.Wysokość;

            P = w * h;
            O = 2 * h + 2 * w;
            DaneWyjścioweOkno oknoWy = new DaneWyjścioweOkno(P,O);

            //oknoWy.tbkObw.Text = $"{O:F2}";
           // oknoWy.tbkPole.Text = $"{P:F2}";
            oknoWy.ShowDialog();

        }
    }
}