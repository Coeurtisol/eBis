using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eBis.common.Models
{
    public class Secteur
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [DataMember]
        [BsonElement("nom")]
        public string Nom { get; set; }

        //[BsonConstructor]
        //public Secteur(string nom)
        //{
        //    Nom = nom;
        //}
    }
}
