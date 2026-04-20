using DataAccess;
using Entities;

namespace StockFlow.Business
{
    public class StockMovementService
    {
        private readonly StockMovementRepository _stockMovementRepository;
        private readonly ProductRepository _productRepository;

        public StockMovementService()
        {
            _stockMovementRepository = new StockMovementRepository();
            _productRepository = new ProductRepository();
        }

        public List<StockMovement> GetStockMovements()
        {
            return _stockMovementRepository.GetAllStockMovements();
        }

        public StockMovement GetStockMovementById(int id)
        {
            if (id <= 0)
                return null;

            var existing = _stockMovementRepository.GetStockMovementById(id);

            return existing;
        }
        public string AddStockMovement(StockMovement stockMovement)
        {
            if (stockMovement == null)
                return "Stock Movement information cannot be empty";
            if (stockMovement.Quantity <= 0)
                return "Quantity must be greater than 0";
            var product = _productRepository.GetProductById(stockMovement.ProductId);
            if (product == null)
                return "Product not found";

            if (stockMovement.Type == MovementType.Out)
            {
                if (product.ProductStock < stockMovement.Quantity)
                    return "Insufficient Stock.";

                product.ProductStock -= stockMovement.Quantity;
            }
            else
            {
                product.ProductStock += stockMovement.Quantity;
            }

            _productRepository.UpdateProduct(product);
            _stockMovementRepository.AddStockMovement(stockMovement);

            return "Stock Movement added successfully";

        }
        public string UpdateStockMovement(StockMovement stockMovement)
        {
            if (stockMovement == null)
                return "Stock Movement information cannot be empty";

            var existing = _stockMovementRepository.GetStockMovementById(stockMovement.StockMovementId);

            if (existing == null)
                return "Stock Movement not found";

            var product = _productRepository.GetProductById(existing.ProductId);

            if (product == null)
                return "Product not found";

            if (existing.Type == MovementType.In)
                product.ProductStock -= existing.Quantity;
            else
                product.ProductStock += existing.Quantity;

            if (stockMovement.Type == MovementType.Out)
            {
                if (product.ProductStock < stockMovement.Quantity)
                    return "Insufficient Stock.";

                product.ProductStock -= stockMovement.Quantity;
            }
            else
            {
                product.ProductStock += stockMovement.Quantity;
            }

            _productRepository.UpdateProduct(product);
            _stockMovementRepository.UpdateStockMovement(stockMovement);

            return "Stock Movement updated successfully";
        }

        public string DeleteStockMovement(int id)
        {
            if (id <= 0)
                return "Invalid Id";

            var existing = _stockMovementRepository.GetStockMovementById(id);

            if (existing == null)
                return "Stock Movement not found";

            var product = _productRepository.GetProductById(existing.ProductId);

            if (existing.Type == MovementType.In)
                product.ProductStock -= existing.Quantity;
            else
                product.ProductStock += existing.Quantity;

            _productRepository.UpdateProduct(product);
            _stockMovementRepository.DeleteStockMovement(id);

            return "Stock Movement deleted successfully";
        }

    }
}
