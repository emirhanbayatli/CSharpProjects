using Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class CategoryRepository
    {
        AppDbContext db = new AppDbContext();
        public List<Category> GetAllCategories()
        {
            var values = db.Categories.ToList();
            return values;
        }
        public Category GetCategoryById(int id)
        {
            var values = db.Categories.Find(id);
            return values;
        }
        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            var category = db.Categories.Find(id);

            db.Categories.Remove(category);
            db.SaveChanges();

        }


    }
}
