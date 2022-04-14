using eBis.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.ViewModels
{
    public class TechnicienSelectViewModel : ViewModelBase
    {
        private ITechnicienDataProvider _technicienDataProvider;
        private TechnicienViewModel technicienSelectionne;
        public ObservableCollection<TechnicienViewModel> Techniciens { get; }

        public TechnicienSelectViewModel(ITechnicienDataProvider technicienDP)
        {
            _technicienDataProvider = technicienDP;
            Techniciens = new();
        }

        public TechnicienViewModel TechnicienSelectionne
        {
            get => technicienSelectionne;

            set
            {
                if (technicienSelectionne != value)
                {
                    technicienSelectionne = value;
                    RaisePropertyChanged();
                }

            }
        }

        public void Charger()
        {
            var techniciens = _technicienDataProvider.getAllTechniciens();
            Techniciens.Clear();

            foreach( var technicien in techniciens)
            {

                Techniciens.Add(new TechnicienViewModel(technicien));
            }
        }
    }
}
