using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.common.Interfaces
{
    public interface ISecteurDataProvider
    {
        List<Secteur> getAllSecteur();
        Secteur getSecteur(string secteurId);
    }
}
