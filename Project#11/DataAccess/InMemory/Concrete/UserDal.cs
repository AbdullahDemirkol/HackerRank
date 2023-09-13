using Project_11.DataAccess.InMemory.Abstract;
using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.DataAccess.InMemory.Concrete
{
    internal class UserDal : IUserDal
    {
        private List<User> _users;
        private int idGenerater = 2;

        public UserDal()
        {
            _users = new List<User>()
            {
                new User{ Id = 1 , Username = "abdullah" , Password = "123456"}
            };
        }

        public bool Add(User user)
        {
            try
            {
                user.Id = idGenerater;
                user.Username = user.Username.ToLower();
                user.Password = user.Password.ToLower();
                _users.Add(user);
                idGenerater++;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<User> GetAll()
        {
            return _users.ToList();
        }

        public User GetByUsername(string username)
        {
            return _users.SingleOrDefault(c => c.Username == username.ToLower());
        }
    }
}
