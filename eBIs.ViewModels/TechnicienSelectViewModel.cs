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
        private ISecteurDataProvider _secteurDataProvider;
        private TechnicienViewModel technicienSelectionne;
        public ObservableCollection<TechnicienViewModel> Techniciens { get; }

        public TechnicienSelectViewModel(ITechnicienDataProvider technicienDP, ISecteurDataProvider secteurDP)
        {
            _technicienDataProvider = technicienDP;
            _secteurDataProvider = secteurDP;
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
                technicien.NomSecteur = _secteurDataProvider.getSecteur(technicien.Secteur).Nom;
                Techniciens.Add(new TechnicienViewModel(technicien));
            }
        }
    }
}
