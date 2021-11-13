using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayers.UserBusiness
{
    public class UserService
    {

        #region "Methods"

        public void Add(Users item)
        {
            UserRepository.Instance.User.Add(item);
        }

        public Users GetById(int index)
        {
            return UserRepository.Instance.User[index];
        }

        public List<Users> GetAll()
        {
            return UserRepository.Instance.User;
        }


        #endregion

    }
}
