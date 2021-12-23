namespace NataliesCupcakeShop.Data.Entities
{
    public class Order
    {
        public string orderId { get; set; }
        public DateTime orderDate { get; set; }
        public string orderNumber { get; set; }
        public ICollection<OrderItem> items { get; set; }
    }
}
