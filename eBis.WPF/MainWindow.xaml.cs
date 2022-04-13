
﻿using eBis.common.Models;
using eBis.WPF.Views;
﻿using eBis.dataAccess.Methods;
using eBis.ViewModels;
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

namespace eBis.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListSecteursViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ListSecteursViewModel(new SecteurMethod());
            DataContext = _viewModel;

            Activated += MainWindow_Activated;
        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {
            _viewModel.Charger();
        }

        private void SecteurSelectView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new SecteurSelectView();
        }

        private void BorneSelectView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BorneSelectView();
        }

        public void AfficherUserControl(UserControl uc)
        {
            zoneDeContenu.Children.Add(uc);
        }
        private void FermerUserControl()
        {
            zoneDeContenu.Children.Clear();
        }

        private bool DoitChargerUserControl(string nomDuControl)
        {
            bool res = true;

            if (zoneDeContenu.Children.Count > 0)
            {
                if (((UserControl)zoneDeContenu.Children[0]).GetType().FullName.Equals(nomDuControl))
                {
                    res = false;
                }
            }

            return res;
        }

        private void ChargerUserControl(string nomDuControl)
        {
            Type ucType = null;
            UserControl uc = null;

            if (DoitChargerUserControl(nomDuControl))
            {

                // Création d'un Type à partir de la string en paramètre
                ucType = Type.GetType(nomDuControl);
                if (ucType == null)
                {
                    MessageBox.Show("Le Control : " + nomDuControl + " est inconnu.");
                }
                else
                {
                    // Fermeture du User Control courant
                    FermerUserControl();

                    // Création réflexive d'une instance du Control demandé
                    uc = (UserControl)Activator.CreateInstance(ucType);
                    if (uc != null)
                    {
                        // Affichage du Control dans la zone de contenu
                        AfficherUserControl(uc);
                    }
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            string cmd;

            // La propriété Tag contient soit une commande,
            // soit le nom d'un User Control à afficher
            if (menu.Tag != null)
            {
                cmd = menu.Tag.ToString();
                // S'il y a un '.' c'est un User Control
                ChargerUserControl(cmd);
            }
        }
    }     
}
