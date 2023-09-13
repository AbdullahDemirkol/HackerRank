using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.DataAccess.InMemory.Abstract
{
    internal interface IUserDal
    {
        public bool Add(User user);
        public List<User> GetAll();
        public User GetByUsername(string username);
    }
}
