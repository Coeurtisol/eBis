using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.common.Models;
using MongoDB.Driver;
using eBis.dataAccess.Methods;

namespace eBis.dataAccess.Methods
{
    public class BorneMethod
    {
        private IMongoCollection<Borne> _borne;

        public BorneMethod()
        {
            _borne = MongoDBHelper.eBisMongoBase.GetCollection<Borne>("borne");
        }

        // Récupère la liste des bornes
        public List<Borne> getAllBornes()
        {
            List<Borne> brn = _borne.Find(s => true).ToList();
            return brn;
        }

        // Récupère la liste des bornes en fonction du secteur
        public List<Borne> getBornesBySecteur(Secteur secteur)
        {
            List<Borne> brnSecteur = new List<Borne>();

            foreach (Borne b in getAllBornes())
            {
                if (b.NomSecteur == secteur.Nom)
                    brnSecteur.Add(b);
            }
            return brnSecteur;
        }
    }
}
