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

namespace eBis.WPF.Views
{
    /// <summary>
    /// Logique d'interaction pour BorneSelectView.xaml
    /// </summary>
    public partial class BorneSelectView : UserControl
    {
        private BorneSelectViewModel _viewModel;

        public BorneSelectView()
        {
            InitializeComponent();
            _viewModel = new BorneSelectViewModel(new BorneMethod());
            DataContext = _viewModel;
            _viewModel.Charger();
        }
    }
}
