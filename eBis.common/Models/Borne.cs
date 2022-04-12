using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eBis.common.Models
{
    public class Borne
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int Numero { get; set; }
        public DateTime DateInstallation { get; set; }
        public DateTime DateDerniereMaintenance { get; set; }
        public Enum TypeDeCharge { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string NomSecteur  { get; set; }

    }
}
