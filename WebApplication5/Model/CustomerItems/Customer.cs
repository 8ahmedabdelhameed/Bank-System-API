using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebApplication4.Model.BankCardItems;
using WebApplication4.Model.BranchItems;
using WebApplication4.Model.Accountitems;

namespace WebApplication4.Model.CustomerItems
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCard BankCard { get; set; } = new BankCard();
        public List<Account> accounts { get; set; } = new List<Account>();
        public List<Branch> branches { get; set; } = new List<Branch>();
    }
}
