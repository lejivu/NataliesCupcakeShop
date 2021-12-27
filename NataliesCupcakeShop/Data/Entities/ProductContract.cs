using Foundation.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NataliesCupcakeShop.Data.Entities
{
    public class ProductContract
    {
        public int productContractId { get; set; }
        public string name { get; set; }
        public CupcakeSize size { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal price { get; set; }
        
        public string description { get; set; }
    }
}
