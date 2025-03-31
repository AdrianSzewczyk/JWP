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
    /// Logika interakcji dla klasy DaneWejścioweOkno.xaml
    /// </summary>
    public partial class DaneWejścioweOkno : Window
    {
        public DaneWejścioweOkno()
        {
            InitializeComponent();
        }

        public double Szerokość
        {
            get
            {
                return Convert.ToDouble(txtSzer.Text);
            }
        }
        public double Wysokość
        {
            get
            {
                return Convert.ToDouble(txtWys.Text);
            }
        }

        private void btnZamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
