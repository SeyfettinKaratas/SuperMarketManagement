using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "beverage", Description = "beverage" },
                new Category { CategoryId = 2, Name = "bakery", Description = "bakery" },
                new Category { CategoryId = 3, Name = "meat", Description = "meat" }
             };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(c => c.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(categories!=null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
           
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate =GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Description = category.Description;
                categoryToUpdate.Name = category.Name;
            }
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }
        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }

        
    }
}
