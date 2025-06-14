using System.ComponentModel.DataAnnotations;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Model.BankCardItems
{
    public class BankCard
    {
        [Key]
        public int BackCardId { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public DateTime ExpireTime { get; set; } = DateTime.Now;
        public int CustomerId { get; set; } 
        public Customer Customer  { get; set; } = new Customer();

    }
}
