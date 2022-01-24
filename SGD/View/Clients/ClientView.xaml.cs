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

namespace SGD.View.Clients
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : Window
    {
        public ClientView()
        {
            InitializeComponent();
        }



        private void tbox_Recherche_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //récupération du texte à rechercher
            string filtre = this.tbox_rechercher.Text;


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

        private void Button_NewClient(object sender, RoutedEventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListClientPrint print = new ListClientPrint();
            print.Show();
        }
    }
}
