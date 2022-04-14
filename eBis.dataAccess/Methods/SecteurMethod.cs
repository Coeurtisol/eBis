using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.dataAccess;
using eBis.common;
using eBis.common.Models;
using eBis.common.Interfaces;


namespace eBis.dataAccess.Methods
{
    public class SecteurMethod : ISecteurDataProvider
    {
        private IMongoCollection<Secteur> _secteur; // accès à la collection

        public SecteurMethod()
        {
            _secteur = MongoDBHelper.eBisMongoBase.GetCollection<Secteur>("secteur"); // connexion à la collection
        }

        // Récupère la liste des secteurs 
        public List<Secteur> getAllSecteur()
        {
            List<Secteur> sctr = _secteur.Find(s => true).ToList();
            return sctr;
        }

        public Secteur getSecteur(string secteurId)
        {
            Secteur sctr = _secteur.Find(document => document.Id == secteurId).FirstOrDefault();
            return sctr;
        }
    }
}
