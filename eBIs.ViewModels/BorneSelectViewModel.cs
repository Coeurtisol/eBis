using eBis.common.Interfaces;
using eBis.common.Models;
using GestionEmploye.ViewModels.Command;
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
        private IErreurDataProvider _erreurDataProvider;
        private BorneViewModel borneSelectionne;
        public DelegateCommand ChargerCmd { get; }
        public ObservableCollection<BorneViewModel> Bornes { get; }
        public ObservableCollection<OperationViewModel> Operations { get; }

        public BorneSelectViewModel(IBorneDataProvider borneDP, IOperationDataProvider operationDP, IErreurDataProvider erreurDP)
        {
            _borneDataProvider = borneDP;
            _operationDataProvider = operationDP;
            _erreurDataProvider = erreurDP;
            Bornes = new();
            Operations = new();
            ChargerCmd = new DelegateCommand(ChargerOperation);
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
                borne.Operations = _operationDataProvider.getOperationsByBorne(borne.Id);
                borne.Erreurs = _erreurDataProvider.getErreursByBorne(borne.Id);
                Bornes.Add(new BorneViewModel(borne));
                
            }
        }

        public void ChargerOperation()
        {
            var operations = _operationDataProvider.getOperationsByBorne(BorneSelectionne.Id);


            Operations.Clear();
            
            foreach (var operation in operations)
            {
                Operations.Add(new OperationViewModel(operation));
            }
        }

    }
}
