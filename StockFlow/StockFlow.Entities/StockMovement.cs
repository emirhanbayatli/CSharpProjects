namespace Entities
{

    public enum MovementType
    {
        In,
        Out
    }
    public class StockMovement
    {
        public MovementType Type { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
