using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.Business.Abstract
{
    internal interface IUserService
    {
        public bool IsAuthenticated(string username,string password);
        public bool RegisterUser(User user);
    }
}
