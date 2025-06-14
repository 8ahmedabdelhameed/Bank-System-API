using System.ComponentModel.DataAnnotations;
using WebApplication4.Model.BankCardItems;
using WebApplication4.Model.BranchItems;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Model.Accountitems
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public int Balance { get; set; } 
        public Customer Customer { get; set; } = new Customer();

    }
}
