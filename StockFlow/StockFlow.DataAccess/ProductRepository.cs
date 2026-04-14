using Entities;
using System.Data.Entity;

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
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }
}
