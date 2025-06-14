using WebApplication4.Model.Accountitems;
using WebApplication4.Model.AccountItems;
using WebApplication4.Model.BankCardItems;
using WebApplication4.Model.BranchItems;

namespace WebApplication4.Model.CustomerItems
{
    public class CustomerGetDto
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardPostDto BankCard { get; set; } = new BankCardPostDto();
        public List<BranchPostDto> branches { get; set; } = new List<BranchPostDto>();
    }
    public class CustomerPostDto
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardPostDto BankCard { get; set; } = new BankCardPostDto();
        public List<AccountPostDto> accounts { get; set; } = new List<AccountPostDto>();
        public List<BranchPostDto> branches { get; set; } = new List<BranchPostDto>();
    }
    public class CustomerPostsDto
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public BankCardPostDto BankCard { get; set; } = new BankCardPostDto();
    }
    public class CustomerGetssDto
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public List<AccountPostDto> accounts { get; set; } = new List<AccountPostDto>();
    }

}
