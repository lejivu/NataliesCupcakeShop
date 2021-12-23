namespace NataliesCupcakeShop.Data.Entities
{
    public class OrderItem
    {
        public int orderItemId { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public Order order { get; set; }
    }
}
