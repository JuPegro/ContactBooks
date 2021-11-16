using Database.Models;
using SQLConnection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLayers.UserBusiness
{
    public class UserService
    {
        private UserDataRepository repository;

        public UserService(SqlConnection connection)
        {
            repository = new UserDataRepository(connection);
        }

        #region "Methods"

        public bool Add(DataUser item)
        {
            return repository.Add(item);
        }

        public bool CheckUser(DataUser userName)
        {
            string nick = repository.CheckUser(userName.UserName).UserName;
            if (userName.UserName == nick)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public DataUser Login(string username, string password)
        {
            return repository.Login(username, password);
        }


        #endregion

    }
}
