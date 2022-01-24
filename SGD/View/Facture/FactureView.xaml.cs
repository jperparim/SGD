using SGD.View.Login_User;
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

namespace SGD.View.Facture
{
    /// <summary>
    /// Logique d'interaction pour FactureView.xaml
    /// </summary>
    public partial class FactureView : Window
    {
        public FactureView()
        {
            InitializeComponent();
        }

        private void tbox_rechercher_Devis_TextChanged(object sender, TextChangedEventArgs e)
        {
            //récupération du texte à rechercher
            string filtre = this.tbox_rechercher_Facture.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Profil prof2 = new Profil();
            prof2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListFacturePrint printfacture = new ListFacturePrint();
            printfacture.Show();
        }
    }
}
