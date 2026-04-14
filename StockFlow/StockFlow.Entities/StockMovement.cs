namespace Entities
{

    public enum MovementType
    {
        In,
        Out
    }
    public class StockMovement
    {
        public int StockMovementId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public MovementType Type { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
