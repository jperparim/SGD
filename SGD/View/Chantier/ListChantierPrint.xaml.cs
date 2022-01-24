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

namespace SGD.View.Chantier
{
    /// <summary>
    /// Logique d'interaction pour ListChantierPrint.xaml
    /// </summary>
    public partial class ListChantierPrint : Window
    {
        public ListChantierPrint()
        {
            InitializeComponent();
        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
