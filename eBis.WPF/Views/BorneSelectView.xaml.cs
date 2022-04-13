using eBis.WPF.ViewModels;
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

namespace eBis.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour BorneSelectView.xaml
    /// </summary>
    public partial class BorneSelectView : UserControl
    {

        public BorneSelectView()
        {
            InitializeComponent();
        }

        public void AfficherUserControl(UserControl uc)
        {
            zoneDeContenu.Children.Add(uc);
        }

        private void ChargerUserControl(string nomDuControl)
        {
            Type ucType = null;
            UserControl uc = null;

            // Création d'un Type à partir de la string en paramètre
            ucType = Type.GetType(nomDuControl);
            // Création réflexive d'une instance du Control demandé
            uc = (UserControl)Activator.CreateInstance(ucType);
            if (uc != null)
            {
                // Affichage du Control dans la zone de contenu
                AfficherUserControl(uc);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            string cmd;

            // La propriété Tag contient soit une commande,
            // soit le nom d'un User Control à afficher
            cmd = menu.Tag.ToString();
            // S'il y a un '.' c'est un User Control
            ChargerUserControl(cmd);
        }
    }
}
