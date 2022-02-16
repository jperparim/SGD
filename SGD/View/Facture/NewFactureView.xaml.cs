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
using SGD.View.Chantier;
using SGD.View.Clients;
using SGD.View.Devis;
using SGD.View.Login_User;

namespace SGD.View.Facture
{
    /// <summary>
    /// Logique d'interaction pour NewFactureView.xaml
    /// </summary>
    public partial class NewFactureView : Window
    {
        public NewFactureView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewChantier newChantier = new NewChantier();
            newChantier.Show();

        }

        private void Nouveau_Client(object sender, RoutedEventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void home(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Hide();
        }

        private void Nouveau_Chantier(object sender, RoutedEventArgs e)
        {
            NewChantier newChantier = new NewChantier();
            newChantier.Show();
        }

        private void Profil(object sender, RoutedEventArgs e)
        {
            Profil prof2 = new Profil();
            prof2.Show();
        }
    }
}
