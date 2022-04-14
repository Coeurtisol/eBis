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
    public class OperationMethod : IOperationDataProvider
    {
        private IMongoCollection<Operation> _operation;

        public OperationMethod()
        {
            _operation = MongoDBHelper.eBisMongoBase.GetCollection<Operation>("operation");
        }

        // Récupère la liste des opérations
        public List<Operation> getAllOperations()
        {
            List<Operation> opt = _operation.Find(s => true).ToList();
            return opt;
        }

        // Récupère la liste des opérations par borne
        public List<Operation> getOperationsByBorne(Borne borne)
        {
            List<Operation> optSecteur = new List<Operation>();

            foreach (Operation o in getAllOperations())
            {
                if (o.Borne.Numero == borne.Numero)
                    optSecteur.Add(o);
            }
            return optSecteur;
        }
    }
}
