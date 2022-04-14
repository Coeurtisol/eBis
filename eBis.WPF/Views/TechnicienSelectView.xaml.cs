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
using eBis.dataAccess.Methods;
using eBis.ViewModels;

namespace eBis.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour TechnicienSelectView.xaml
    /// </summary>
    public partial class TechnicienSelectView : UserControl
    {
        private TechnicienSelectViewModel _viewModel;

        public TechnicienSelectView()
        {
            InitializeComponent();
            _viewModel = new TechnicienSelectViewModel(new TechnicienMethod(), new SecteurMethod());
            DataContext = _viewModel;
            _viewModel.Charger();
        }
    }
}
