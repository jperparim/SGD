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

namespace SGD.View.Devis
{
    /// <summary>
    /// Logique d'interaction pour ListDevisPrint.xaml
    /// </summary>
    public partial class ListDevisPrint : Window
    {
        public ListDevisPrint()
        {
            InitializeComponent();
        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
