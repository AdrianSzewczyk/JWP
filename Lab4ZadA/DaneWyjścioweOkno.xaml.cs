using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZadA
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWyjścioweOkno.xaml
    /// </summary>
    public partial class DaneWyjścioweOkno : Window
    {
        public DaneWyjścioweOkno()
        {
            InitializeComponent();
        }

        public DaneWyjścioweOkno(double pole,double obwód):this()
        {
            this.tbkPole.Text = $"{pole:F2}";
            this.tbkObw.Text = $"{obwód:F2}";
        }

        private void btnZamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
