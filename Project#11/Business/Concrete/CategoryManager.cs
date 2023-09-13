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
    internal class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public List<Category> GetCategories()
        {
            return categoryDal.GetAll();
        }
    }
}
