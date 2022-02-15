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

namespace SGD.View.Devis
{
    /// <summary>
    /// Logique d'interaction pour DevisView.xaml
    /// </summary>
    public partial class DevisView : Window
    {
        public DevisView()
        {
            InitializeComponent();
        }

        private void tbox_rechercher_Devis_TextChanged(object sender, TextChangedEventArgs e)
        {

                //récupération du texte à rechercher
                string filtre = this.tbox_rechercher_Devis.Text;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Profil prof = new Profil();
            prof.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListDevisPrint devisprint = new ListDevisPrint();
            devisprint.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NewDevisView NouveauDevis = new NewDevisView();
            NouveauDevis.Show();
        }
    }
}
