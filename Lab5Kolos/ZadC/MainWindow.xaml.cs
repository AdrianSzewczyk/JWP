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

namespace ZadDom1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnStworz_Click(object sender, RoutedEventArgs e)
    {
        Samochód s1 = new Samochód();
        s1.Prędkość = 10;
        lista.Items.Add("Po stworzeniu: " + s1);

        IZwiekszany z = s1;
        z.Zmień(); // +10
        lista.Items.Add("Po zwiększeniu: " + s1);

        IZmniejszamy m = s1;
        m.Zmień(); // -5
        lista.Items.Add("Po zmniejszeniu: " + s1);



    }
}