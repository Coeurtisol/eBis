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
    public class Borne
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [DataMember]
        [BsonElement("numero")]

        public string Numero { get; set; }


        [DataMember]
        [BsonElement("dateInstallation")]
        public DateTime DateInstallation { get; set; }

        [DataMember]
        [BsonElement("dateDerniereMaintenance")]
        public DateTime DateDerniereMaintenance { get; set; }

        [DataMember]
        [BsonElement("typeCharge")]

        public string TypeDeCharge { get; set; }


        [DataMember]
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        [DataMember]
        [BsonElement("longitude")]
        public string Longitude { get; set; }

        [DataMember]
        [BsonElement("secteur")]
        [BsonRepresentation(BsonType.ObjectId)]

        public ObjectId Secteur  { get; set; }

    }
}
