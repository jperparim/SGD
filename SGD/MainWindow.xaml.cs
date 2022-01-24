using SGD.View.Chantier;
using SGD.View.Clients;
using SGD.View.Devis;
using SGD.View.Facture;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGD
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                Close();
            }
        }


        private void Button_Client(object sender, RoutedEventArgs e)
        {
            ClientView client = new ClientView();
            client.Show();
            this.Hide();
        }

        private void Button_Chantier(object sender, RoutedEventArgs e)
        {
            ChantierView chantier = new ChantierView();
            chantier.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DevisView devisview = new DevisView();
            devisview.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FactureView factureview = new FactureView();
            factureview.Show();
            this.Hide();
        }
    }
}
