using System.ComponentModel.DataAnnotations.Schema;

namespace NataliesCupcakeShop.Data.Entities
{
    public class OrderItemContract
    {
        public int orderItemContractId { get; set; }
        public ProductContract product { get; set; }
        public int quantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal unitPrice { get; set; }
        public OrderContract order { get; set; }
    }
}
