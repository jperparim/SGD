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
using SGD.View.Clients;
using SGD.View.Login_User;

namespace SGD.View.Chantier
{
    /// <summary>
    /// Logique d'interaction pour ChantierView.xaml
    /// </summary>
    public partial class ChantierView : Window
    {
        public ChantierView()
        {
            InitializeComponent();
        }






        private void tbox_rechercher1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //récupération du texte à rechercher
            string filtre = this.tbox_rechercher1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListChantierPrint printChantier = new ListChantierPrint();
            printChantier.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NewChantier newchantier = new NewChantier();
            newchantier.Show();
        }
    }
}
