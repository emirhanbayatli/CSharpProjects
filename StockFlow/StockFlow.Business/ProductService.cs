using DataAccess;
using Entities;

namespace StockFlow.Business
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            if (id <= 0)
                return null;

            var existing = _productRepository.GetProductById(id);

            return existing;
        }

        public string AddProduct(Product product)
        {
            if (product == null)
                return "Product information cannot be empty";

            if (string.IsNullOrWhiteSpace(product.ProductName))
                return "Product name cannot be empty";

            if (product.ProductPrice <= 0)
                return "Price must be greater than 0";

            if (product.ProductStock < 0)
                return "Stock cannot be negative";

            var existingProduct = _productRepository
                .GetAllProducts()
                .FirstOrDefault(x => x.ProductName.ToLower() == product.ProductName.ToLower());

            if (existingProduct != null)
                return "A product with this name already exists";

            _productRepository.AddProduct(product);

            return "Product added successfully";
        }

        public string UpdateProduct(Product product)
        {
            if (product == null)
                return "Product information cannot be empty";

            if (string.IsNullOrWhiteSpace(product.ProductName))
                return "Product name cannot be empty";

            if (product.ProductPrice <= 0)
                return "Price must be greater than 0";

            if (product.ProductStock < 0)
                return "Stock cannot be negative";

            var existing = _productRepository.GetProductById(product.ProductId);

            if (existing == null)
                return "Product not found";

            _productRepository.UpdateProduct(product);
            return "Product updated successfully";
        }

        public string DeleteProduct(int id)
        {
            if (id <= 0)
                return "Invalid Id";

            var existing = _productRepository.GetProductById(id);

            if (existing == null)
                return "Product not found";

            _productRepository.DeleteProduct(id);
            return "Product deleted successfully";
        }
    }
}