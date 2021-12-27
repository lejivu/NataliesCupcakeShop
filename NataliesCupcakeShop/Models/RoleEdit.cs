using Microsoft.AspNetCore.Identity;
using NataliesCupcakeShop.Data.Entities;

namespace NataliesCupcakeShop.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<UserContract> Members { get; set; }
        public IEnumerable<UserContract> NonMembers { get; set; }
    }
}
