using SimpleBot.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleBot.Data.Context
{

    public class BotContext : DbContext
    {
        public DbSet<UserProfileSql> userProfileSql { get; set; }

}