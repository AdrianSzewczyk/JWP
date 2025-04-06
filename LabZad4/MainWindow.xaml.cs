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
using Geometria;

namespace ZadanieB;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnKula_Click(object sender, RoutedEventArgs e)
    {
        Kula kula=new Kula(2, 3, 4);
        lbNapis.Content =kula;
        
    }

    private void TestButton_Click(object sender, RoutedEventArgs e)
    {
        // Tworzymy kulę 1 (gęstość 2, cena 10, promień 3)
        Kula kula1 = new Kula(2, 10, 3);
        // Tworzymy kulę 2 (gęstość 2, cena 10, promień 4)
        Kula kula2 = new Kula(2, 10, 4);

        // Testujemy operator +
        Kula kula3 = kula1 + kula2;
        ListBox1.Items.Add($"Kula 1 + Kula 2: {kula3.ToString()}");

        // Testujemy operator -
        Kula kula4 = kula1 - kula2;
        ListBox1.Items.Add($"Kula 1 - Kula 2: {kula4.ToString()}");

        // Testujemy operator ++
        Kula kula5 = ++kula1;
        ListBox1.Items.Add($"Kula 1 po ++: {kula5.ToString()}");
    }
}