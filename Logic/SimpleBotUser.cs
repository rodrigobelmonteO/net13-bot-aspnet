using MongoDB.Driver;
using SimpleBot.Connection;
using SimpleBot.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot
{

    public class SimpleBotUser
    {
        static IUserProfileRepository _user;
        public SimpleBotUser()
        {
            _user = new UserProfileMongoRepository();
        }
        public static string Reply(Message message)
        {
            var messageBson = new MessageBson(message.Id, message.User, message.Text);
            //INSERT
            mongoDB.postDocument(messageBson);
            //GET
            var user = _user.GetProfile(message.Id);

            return $"{message.User} disse '{message.Text}' e mandou { user.Visitas } mensagens";
        }

    }
}