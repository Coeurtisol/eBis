using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.common.Models;
using eBis.common.Interfaces;
using MongoDB.Driver;
using eBis.dataAccess.Methods;

namespace eBis.dataAccess.Methods
{
    public class ErreurMethod : IErreurDataProvider
    {
        private IMongoCollection<Erreur> _erreur;

        public ErreurMethod()
        {
            _erreur = MongoDBHelper.eBisMongoBase.GetCollection<Erreur>("erreur");
        }

        // Récupère la liste des erreurs
        public List<Erreur> getAllErreurs()
        {
            List<Erreur> err = _erreur.Find(s => true).ToList();
            return err;
        }

        // Récupère la liste des erreurs par borne
        public List<Erreur> getErreursByBorne(string borneId)
        {
            List<Erreur> errSecteur = new List<Erreur>();

            foreach (Erreur e in getAllErreurs())
            {
                if (e.Borne == borneId)
                    errSecteur.Add(e);
            }
            return errSecteur;
        }
    }
}
