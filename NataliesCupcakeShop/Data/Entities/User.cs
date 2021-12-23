namespace NataliesCupcakeShop.Data.Entities
{
    public class User
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }
        public DateTime createDate { get; set; }
    }
}
