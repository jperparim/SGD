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

namespace SGD.View.Devis
{
    /// <summary>
    /// Logique d'interaction pour NewDevisView.xaml
    /// </summary>
    public partial class NewDevisView : Window
    {
        public NewDevisView()
        {
            InitializeComponent();
        }

        private void Nouveau_Chantier(object sender, RoutedEventArgs e)
        {
            NewChantier NouveauChantier = new NewChantier();
            NouveauChantier.Show();
        }

        private void Nouveau_Client(object sender, RoutedEventArgs e)
        {
            NewClient NouveauClient = new NewClient();
            NouveauClient.Show();
        }

        private void home(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Hide();
        }
    }
}
