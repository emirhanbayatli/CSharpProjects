using Entities;

namespace DataAccess
{
    public class ProductRepository
    {
        AppDbContext db = new AppDbContext();
        public List<Product> GetAllProducts()
        {
            var values = db.Products.ToList();
            return values;
        }
        public Product GetProductById(int id)
        {
            var values = db.Products.Find(id);
            return values;
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();

        }

        public void UpdateProduct(Product product)
        {
            var entity = db.Products.Find(product.ProductId);
            entity.ProductName = product.ProductName;
            entity.ProductPrice = product.ProductPrice;
            entity.ProductStock = product.ProductStock;
            entity.ProductDescription = product.ProductDescription;
            entity.IsActive = product.IsActive;
            entity.CategoryId = product.CategoryId;

            db.SaveChanges();

        }
        public void DeleteProduct(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();

        }
    }
}
