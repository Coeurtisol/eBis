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
    public class TechnicienMethod : ITechnicienDataProvider
    {
        private IMongoCollection<Technicien> _technicien;

        public TechnicienMethod()
        {
            _technicien = MongoDBHelper.eBisMongoBase.GetCollection<Technicien>("technicien");
        }

        // Récupère la liste des techniciens
        public List<Technicien> getAllTechniciens()
        {
            List<Technicien> tcn = _technicien.Find(s => true).ToList();
            return tcn;
        }

        // Récupère la liste des techniciens en fonction du secteur 
        public List<Technicien> getTechniciensBySecteur(string secteurId)
        {
            List<Technicien> tcnSecteur = new List<Technicien>();

            foreach (Technicien t in getAllTechniciens())
            {
                if (t.Secteur == secteurId)
                    tcnSecteur.Add(t);
            }
            return tcnSecteur;
        }
    }
}
