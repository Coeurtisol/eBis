using eBis.common.Interfaces;
using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.ViewModels
{
    public class BorneSelectViewModel:ViewModelBase
    {
        private IBorneDataProvider _borneDataProvider;
        private IOperationDataProvider _operationDataProvider;
        private BorneViewModel borneSelectionne;
        public ObservableCollection<BorneViewModel> Bornes { get; }
        public ObservableCollection<OperationViewModel> Operations { get; }
        public BorneSelectViewModel(IBorneDataProvider borneDP)
        {
            _borneDataProvider = borneDP;
            Bornes = new();
        }

        public BorneViewModel BorneSelectionne
        {
            get => borneSelectionne;

            set
            {
                if (borneSelectionne != value)
                {
                    borneSelectionne = value;
                    RaisePropertyChanged();
                }

            }
        }

        public void Charger()
        {
            var bornes = _borneDataProvider.getAllBornes();

            Bornes.Clear();
            foreach (var borne in bornes)
            {
                Bornes.Add(new BorneViewModel(borne));
            }
        }

        public void ChargerOperation(Borne borne)
        {
            var operations = _operationDataProvider.getOperationsByBorne(borne);
            Operations.Clear();
            foreach (var operation in operations)
            {
                Operations.Add(new OperationViewModel(operation));
            }
        }

    }
}
