using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.DataAccess.InMemory.Abstract
{
    internal interface ICategoryDal
    {
        public List<Category> GetAll();
    }
}
