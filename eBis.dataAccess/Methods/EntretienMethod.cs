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
    public class EntretienMethod
    {
        private IMongoCollection<Entretien> _entretien;

        public EntretienMethod()
        {
            _entretien = MongoDBHelper.eBisMongoBase.GetCollection<Entretien>("entretien");
        }

        // Récupère la liste des entretiens
        public List<Entretien> getAllEntretiens()
        {
            List<Entretien> ett = _entretien.Find(s => true).ToList();
            return ett;
        }

        // Récupère la liste des entretiens par borne
        public List<Entretien> getEntretiensByBorne(Borne borne)
        {
            List<Entretien> ettSecteur = new List<Entretien>();
            
            foreach(Entretien e in getAllEntretiens())
            {
                if (e.NumeroBorne == borne.Numero)
                    ettSecteur.Add(e);
            }
            return ettSecteur;
        }
    }
}
