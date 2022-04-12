using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBis.dataAccess;
using eBis.common;
using eBis.common.Models;


namespace eBis.dataAccess.Methods
{
    public class SecteurMethod
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
    }
}
