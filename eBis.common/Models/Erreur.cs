using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eBis.common.Models
{
    public class Erreur
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Enum TypeIncident { get; set; }  
        public string DetailsIncident { get; set; }
        public int NumeroBorne { get; set; }
        public DateTime Date { get; set; }
    }
}
