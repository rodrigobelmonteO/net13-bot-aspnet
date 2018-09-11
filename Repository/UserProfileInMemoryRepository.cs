using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Repository
{
    public class UserProfileInMemoryRepository : IUserProfileRepository
    {
        public UserProfile GetProfile(string id)
        {
            throw new NotImplementedException();
        }

        public void SetProfile(string id, UserProfile profile)
        {
            throw new NotImplementedException();
        }
    }
}