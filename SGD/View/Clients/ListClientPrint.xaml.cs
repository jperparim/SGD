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

namespace SGD.View.Clients
{
    /// <summary>
    /// Logique d'interaction pour ListClientPrint.xaml
    /// </summary>
    public partial class ListClientPrint : Window
    {
        public ListClientPrint()
        {
            InitializeComponent();
        }

        private void btn_annulerUser_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
