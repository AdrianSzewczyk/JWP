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
using Microsoft.Data;
using Microsoft.Data.SqlClient;

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

        private void btnPolacz_Click(object sender, RoutedEventArgs e)
        {
            lbTowary.Items.Clear();
            using (SqlConnection połączenie = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sklep;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand polecenie = new SqlCommand("SELECT Nazwa,Cena FROM Towary", połączenie);
                połączenie.Open();
                SqlDataReader czytnik = polecenie.ExecuteReader();
                while(czytnik.Read())
                {
                    lbTowary.Items.Add($"Nazwa: {czytnik["Nazwa"]}, Cena: {czytnik["Cena"]:C}");
                }
                czytnik.Close();
                //połączenie.Close();
            }
        }
    }
}