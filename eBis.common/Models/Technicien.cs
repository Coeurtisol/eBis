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
    public class Technicien
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [DataMember]
        [BsonElement("nom")]
        public string Nom { get; set; }

        [DataMember]
        [BsonElement("prenom")]
        public string Prenom { get; set; }

        [DataMember]
        [BsonElement("telephone")]
        public string Telephone { get; set; }

        [DataMember]
        [BsonElement("secteur")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Secteur { get; set; }
    }
}
