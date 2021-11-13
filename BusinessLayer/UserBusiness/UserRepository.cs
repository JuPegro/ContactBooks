using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayers.UserBusiness
{
    public sealed class UserRepository
    {

        public static UserRepository Instance { get; } = new UserRepository();

        public List<Users> User { get; set; } = new List<Users>();

        private UserRepository()
        {

        }

    }
}
