using Foundation.Enums;

namespace NataliesCupcakeShop.Data.Entities
{
    public class Product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public CupcakeSize size { get; set; }
        public decimal price { get; set; }
        
        public string description { get; set; }
    }
}
