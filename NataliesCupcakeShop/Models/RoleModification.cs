using System.ComponentModel.DataAnnotations;

namespace NataliesCupcakeShop.Models
{
    public class RoleModification
    {
        public string RoleName { get; set; }

        public string RoleId { get; set; }

        public List<string> AddIds { get; set; }

        public List<string> DeleteIds { get; set; }
    }
}