using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;


namespace SimpleBot
{
    public class SimpleBotUser
    {

        public static string Reply(Message message)
        {
            string conn = "mongodb://localhost:27017";

            var client = new MongoClient(conn);


            var doc = new BsonDocument
            {
                {"id", message.Id },
                {"texto", message.Text},
                {"botName", "17" },
                {message.User, "Rodrigo"  }
            };

            var db = client.GetDatabase("db01");
            var col = db.GetCollection<BsonDocument>("tabela01");

            col.InsertOne(doc);

            return $"{message.User} disse '{message.Text}'";

        }

        public static UserProfile GetProfile(string id)
        {
            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {
        }
    }
}