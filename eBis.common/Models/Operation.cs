using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        [DataMember]
        [BsonElement("typeCharge")]
        public Enum TypeDeCharge { get; set; }

        [DataMember]
        [BsonElement("dateHeureDebut")]
        public DateTime DateDebutCharge { get; set; }

        [DataMember]
        [BsonElement("dateHeureFin")]
        public DateTime DateFinCharge   { get; set; }

        [DataMember]
        [BsonElement("nbKwHeures")]
        public double KWConsommes { get; set; }

        [DataMember]
        [BsonElement("borne")]
        [BsonRepresentation(BsonType.ObjectId)]
        public Borne Borne { get; set; }
    }
}
