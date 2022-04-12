using System;
using System.Collections.Generic;
using System.Linq;
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
        public int NumeroBorne { get; set; }    
        public string PositionBorne { get; set; }
        public Technicien TechnicienEnCharge { get; set; }  
        public List<string> ElementVerifies { get; set; }


    }
}
