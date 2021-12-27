namespace NataliesCupcakeShop.Data.Entities
{
    public class OrderContract
    {
        public string orderContractId { get; set; }
        public DateTime orderDate { get; set; }
        public string orderNumber { get; set; }
        public ICollection<OrderItemContract> items { get; set; }
    }
}
