using Entities;

namespace DataAccess
{
    public class StockMovementRepository
    {
        AppDbContext db = new AppDbContext();
        public List<StockMovement> GetAllStockMovements()
        {
            var values = db.StockMovements.ToList();
            return values;
        }

        public StockMovement GetStockMovementById(int id)
        {
            var values = db.StockMovements.Find(id);
            return values;
        }

        public void AddStockMovement(StockMovement stockMovement)
        {
            db.StockMovements.Add(stockMovement);
            db.SaveChanges();
        }
        public void UpdateStockMovement(StockMovement stockMovement)
        {
            var entity = db.StockMovements.Find(stockMovement.StockMovementId);

            entity.Quantity = stockMovement.Quantity;
            entity.Date = stockMovement.Date;
            entity.Description = stockMovement.Description;
            entity.ProductId = stockMovement.ProductId;
            entity.Type = stockMovement.Type;

            db.SaveChanges();
        }

        public void DeleteStockMovement(int id)
        {
            var stockMovement = db.StockMovements.Find(id);
            db.StockMovements.Remove(stockMovement);
            db.SaveChanges();

        }
    }
}
