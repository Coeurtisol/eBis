using eBis.dataAccess.Methods;
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
    }
}
