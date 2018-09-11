using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository
{
    public class UserProfileMongo
    {
        public string _id { get; set; }

        [BsonElement("visits")]
        public int Visitas { get; set; }
    }
}