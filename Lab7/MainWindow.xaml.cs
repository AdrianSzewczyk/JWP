using System.IO;
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

        private void btnMelduj_Click(object sender, RoutedEventArgs e)
        {
            string data = DateTime.Now.ToShortDateString();
            FileStream fs = new FileStream(@"C:\Users\Student\Desktop\LaboratoriumSzewczyk\Laboratorium 7\ZadA\rejestr.txt", FileMode.Append, FileAccess.Write,FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            sw.Close();
        }

        private void btnCzytaj_Click(object sender, RoutedEventArgs e)
        {
            lsLista.Items.Clear();

            List<int> listaDanych = new List<int>();
            using (FileStream fsDane = new FileStream(
                @"C:\Users\Student\Desktop\LaboratoriumSzewczyk\Laboratorium 7\ZadA\dane.txt",
                FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader srDane = new StreamReader(fsDane))
            {
                string linia;
                while ((linia = srDane.ReadLine()) != null)
                {
                    lsLista.Items.Add($"Liczba: {linia}");

                    
                    if (int.TryParse(linia, out int liczba))
                    {
                        listaDanych.Add(liczba);
                    }
                    else
                    {
                        MessageBox.Show($"Nieprawidłowa liczba: {linia}");
                    }
                }
            }
            var srednia = listaDanych.Average();
            var najmniejsza = listaDanych.Min();
            var najwieksza = listaDanych.Max();
            lblŚrednia.Content = srednia.ToString();
            lblNajwieksza.Content = najwieksza.ToString();
            lblNajmniejsza.Content = najmniejsza.ToString();
            
        }


        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {

            FileStream fsDane = new FileStream(@"C:\Users\Student\Desktop\LaboratoriumSzewczyk\Laboratorium 7\ZadA\dane.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter swDane = new StreamWriter(fsDane);
            //sw.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                swDane.WriteLine(i);
            }
            swDane.Close();
        }
    }
}