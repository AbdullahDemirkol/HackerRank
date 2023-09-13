using Project_11.DataAccess.InMemory.Abstract;
using Project_11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11.DataAccess.InMemory.Concrete
{
    internal class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category() { Id = 1, CategoryName = "Science and Technology" },
                new Category() { Id = 2 , CategoryName = "Sports"},
                new Category() { Id = 3 , CategoryName = "Movies"},
                new Category() { Id = 4 , CategoryName = "History and Geography"},
                new Category() { Id = 5 , CategoryName = "Animals"},
            };
        }

        public List<Category> GetAll()
        {
            return _categories.ToList();
        }

    }
}
