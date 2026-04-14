using DataAccess;
using Entities;

namespace StockFlow.Business
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            if (id <= 0)
                return null;

            var category = _categoryRepository.GetCategoryById(id);

            if (category == null)
                return null;

            return category;
        }

        public string AddCategory(Category category)
        {
            if (category == null)
                return "Category information cannot be empty";

            if (string.IsNullOrWhiteSpace(category.CategoryName))
                return "Category name cannot be empty";

            var existingCategory = _categoryRepository
                .GetAllCategories()
                .FirstOrDefault(x => x.CategoryName == category.CategoryName);

            if (existingCategory != null)
                return "A category with this name already exists";

            _categoryRepository.AddCategory(category);
            return "Category added successfully";
        }

        public string UpdateCategory(Category category)
        {
            if (category == null)
                return "Category information cannot be empty";

            if (string.IsNullOrWhiteSpace(category.CategoryName))
                return "Category name cannot be empty";

            var existingCategory = _categoryRepository.GetCategoryById(category.CategoryId);

            if (existingCategory == null)
                return "Category not found";

            _categoryRepository.UpdateCategory(category);
            return "Category updated successfully";
        }

        public string DeleteCategory(int id)
        {
            if (id <= 0)
                return "Invalid Id";

            var existing = _categoryRepository.GetCategoryById(id);

            if (existing == null)
                return "Category not found";

            _categoryRepository.DeleteCategory(id);
            return "Category deleted successfully";
        }
    }
}