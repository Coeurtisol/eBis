using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBis.dataAccess
{
    public class SecteurMethod
    {
        private IMongoCollection<SecteurMethod> _secteur; // accès à la collection

        public SecteurMethod()
        {
            _secteur = MongoDBHelper.eBisMongoBase.GetCollection<SecteurMethod>("secteur"); // connexion à la collection

        }
    }
}
