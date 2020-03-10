using CarsRepository.Interface;
using CarsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsRepository.Repo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return appDbContext.Categories;
        }
        public void CreateCategory(Category category)
        {
            appDbContext.Categories.Add(category);
            appDbContext.SaveChanges();
        }

        public void DeleteCategory(int CategoryId)
        {
            Category dbEntry = appDbContext.Categories.Find(CategoryId);            
            if (dbEntry != null)
            {
                appDbContext.Categories.Remove(dbEntry);
                appDbContext.SaveChanges();
            }
        }

        public void SaveCategory(Category category)
        {
            Category dbEntry = appDbContext.Categories.Find(category.CategoryId);
            if (dbEntry != null)
            {
                dbEntry.CategoryName = category.CategoryName;
                dbEntry.Description = category.Description;                
            }
            appDbContext.SaveChanges();
        }
    }
}
