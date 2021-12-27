using Microsoft.AspNetCore.Identity;

namespace NataliesCupcakeShop.Data.Entities
{
    public class UserContract : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime CreateDate { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
