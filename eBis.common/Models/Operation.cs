using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eBis.common.Models
{
    public class Operation
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Enum TypeDeCharge { get; set; }
        public DateTime DateDebutCharge { get; set; }
        public DateTime DateFinCharge   { get; set; }
        public double KWConsommes { get; set; }
        public int NumeroBorne { get; set; }
    }
}
