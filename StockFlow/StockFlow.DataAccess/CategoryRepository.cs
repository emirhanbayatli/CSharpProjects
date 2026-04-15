using Entities;

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
            var entity = db.Categories.Find(category.CategoryId);
            entity.CategoryName = category.CategoryName;
            entity.IsActive = category.IsActive;
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
