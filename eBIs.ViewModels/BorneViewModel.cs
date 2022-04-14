using eBis.common.Interfaces;
using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.ViewModels
{


    public class BorneViewModel
    {
        private Borne _borne;

        public BorneViewModel(Borne borne)
        {
            _borne = borne;
        }

        public string Id
        {
            get => _borne.Id;
        }

        public string Numero
        {
            get => _borne.Numero;
        }

        public DateTime DateInstallation
        {
            get => _borne.DateInstallation;
        }

        public DateTime DateDerniereMaintenance
        {
            get => _borne.DateInstallation;
        }

        public string TypeDeCharge
        {
            get => _borne.TypeDeCharge;
        }

        public string Latitude
        {
            get => _borne.Latitude;
        }

        public string Longitude
        {
            get => _borne.Longitude;
        }

        public Object Secteur
        {
            get => _borne.Secteur;
        }

        public List<Operation> Operations
        {
            get =>_borne.Operations;
        }

        public List<Erreur> Erreurs
        {
            get => _borne.Erreurs;
        }
    }
}
