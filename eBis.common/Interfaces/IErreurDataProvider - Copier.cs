using eBis.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.common.Interfaces
{
    public interface IErreurDataProvider
    {
        List<Erreur> getAllErreurs();
        List<Erreur> getErreursByBorne(string borneId);
    }
}
