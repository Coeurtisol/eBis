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
    public class Entretien
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [DataMember]
        [BsonElement("borne")]
        [BsonRepresentation(BsonType.ObjectId)]
        public Borne Borne { get; set; }

        [DataMember]
        [BsonElement("technicien")]
        [BsonRepresentation(BsonType.ObjectId)]
        public Technicien TechnicienEnCharge { get; set; }

        [DataMember]
        [BsonElement("elements")]
        public List<string> ElementVerifies { get; set; }

        [DataMember]
        [BsonElement("date")]
        public DateTime Date { get; set; }

    }
}
