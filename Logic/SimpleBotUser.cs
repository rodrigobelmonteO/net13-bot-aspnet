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
        static SimpleBotUser()
        {
            _users = new UserProfileMongoRepository("mongodb://127.0.0.1:27017");
        }

        public static string Reply(Message message)
        {
            var id = message.Id;
            var profile = GetProfile(id);

            //var doc = new BsonDocument
            //{
            //    {"id", message.Id },
            //    {"texto", message.Text},
            //    {"botName", "17" },
            //    {"User", message.User  }
            //};

            //    var db = client.GetDatabase("db01");
            //    var col = db.GetCollection<BsonDocument>("tabela01");
            //    col.InsertOne(doc);


            profile.Visitas += 1;

            SetProfile(id, profile);

            return $"{message.User} disse '{message.Text}' e mandou {profile.Visitas} mensagens";
        }

        //    var db = client.GetDatabase("db01");
        //    var col = db.GetCollection<BsonDocument>("tabela01");

        //    col.InsertOne(doc);

        //    return $"{message.User} disse '{message.Text}'";
        //}

        public static UserProfile GetProfile(string id)
        {
            var db = client.GetDatabase("db01");
            var col = db.GetCollection<BsonDocument>("tabela01");
            var filtro = Builders<BsonDocument>.Filter.Gt("id", id);
            var res = col.Find(filtro).ToList();

            var profile = new UserProfile();




            return null;
        }

        public static void SetProfile(string id, UserProfile profile)
        {

        }
    }
}