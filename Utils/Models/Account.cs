using Utils.Models.Enums;

namespace Utils.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
    }
}