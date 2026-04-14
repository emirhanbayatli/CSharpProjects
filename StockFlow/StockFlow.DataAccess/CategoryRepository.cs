using Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class CategoryRepository
    {
        AppDbContext db = new AppDbContext();
        public List<Category> GetAllCategorys()
        {
            var values = db.Categories.ToList();
            return values;
        }
        public Product GetCategoryById(int id)
        {
            var values = db.Products.Find(id);
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
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }
    }
}
