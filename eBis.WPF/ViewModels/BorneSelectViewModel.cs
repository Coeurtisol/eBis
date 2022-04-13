using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.WPF.ViewModels
{
    public class BorneSelectViewModel:ViewModelBase
    {
        public BorneDetailViewModel CurrentViewModel { get; set; }

        public BorneSelectViewModel()
        {
            CurrentViewModel = new BorneDetailViewModel();
        }

    }
}
