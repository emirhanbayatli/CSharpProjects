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

        public string AddProduct(Product product)
        {
            // 1. Null kontrol
            if (product == null)
                return "Ürün bilgisi boş olamaz";

            // 2. İsim kontrol
            if (string.IsNullOrWhiteSpace(product.ProductName))
                return "Ürün adı boş olamaz";

            // 3. Fiyat kontrol
            if (product.ProductPrice <= 0)
                return "Fiyat 0'dan büyük olmalıdır";

            // 4. Stok kontrol
            if (product.ProductStock < 0)
                return "Stok negatif olamaz";

            // 5. Aynı isimde ürün var mı?
            var existingProduct = _productRepository
                .GetAllProducts()
                .FirstOrDefault(x => x.ProductName == product.ProductName);

            if (existingProduct != null)
                return "Bu isimde bir ürün zaten var";

            // ✔ Her şey doğruysa ekle
            _productRepository.AddProduct(product);

            return "Ürün başarıyla eklendi";
        }
    }
}

