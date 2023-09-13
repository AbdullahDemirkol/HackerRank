using Project_11.Business.Abstract;
using Project_11.DataAccess.InMemory.Abstract;
using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.Business.Concrete
{
    internal class UserManager : IUserService
    {
        private IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public User GetUser(string username)
        {
            return userDal.GetByUsername(username);
        }

        public bool IsAuthenticated(string username, string password)
        {
            User user=userDal.GetByUsername(username);
            if (user!=null) 
            {
                if (user.Password==password.ToLower())
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool RegisterUser(User user)
        {
            try
            {
                userDal.Add(user);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
