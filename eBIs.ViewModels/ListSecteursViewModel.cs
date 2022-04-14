using System;
using eBis.common.Interfaces;
using eBis.common.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GestionEmploye.ViewModels.Command;

namespace eBis.ViewModels
{
    public class ListSecteursViewModel
    {
        private ISecteurDataProvider _secteurDataProvider;
        public ObservableCollection<SecteurViewModel> Secteurs { get; }
        public DelegateCommand ChargerCmd { get; }

        public ListSecteursViewModel(ISecteurDataProvider secteurDP)
        {
            _secteurDataProvider = secteurDP;
            Secteurs = new();
            ChargerCmd = new DelegateCommand(Charger);
        }
        public void Charger()
        {
            var secteurs = _secteurDataProvider.getAllSecteur();

            Secteurs.Clear();
            foreach (var secteur in secteurs)
            {
                Secteurs.Add(new SecteurViewModel(secteur));
            }
        }
    }
}
