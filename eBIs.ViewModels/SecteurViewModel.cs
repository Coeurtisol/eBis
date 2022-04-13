using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.common.Interfaces;
using eBis.common.Models;

namespace eBis.ViewModels
{
    public class SecteurViewModel
    {
        private Secteur _secteur;

        public SecteurViewModel(Secteur secteur)
        {
            _secteur = secteur;
        }

        public string Nom
        {
            get => _secteur.Nom;
        }
    }
}

