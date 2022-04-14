using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.common.Models;

namespace eBis.ViewModels
{
    public class TechnicienViewModel
    {
        private Technicien _technicien;

        public TechnicienViewModel(Technicien technicien)
        {
            _technicien = technicien;
        }

        public string Nom
        {
            get => _technicien.Nom;
        }

        public string Prenom
        {
            get => _technicien.Prenom;
        }

        public string Telephone
        {
            get => _technicien.Telephone;
        }

        public string Secteur
        {
            get => _technicien.Secteur;
        }
    }
}
