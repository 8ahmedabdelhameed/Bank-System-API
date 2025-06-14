using WebApplication4.Model.BankCardItems;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.IRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public CustomerGetDto CustomerGetById(int id)
        {
           var customerDto =  _context.Customers.FirstOrDefault(x => x.CustomerId == id);
            if(customerDto == null)
            {
                return null;
            }
            else
            {
                return new CustomerGetDto
                {
                    CustomerName = customerDto.CustomerName,
                    CustomerEmail = customerDto.CustomerEmail,
                    CustomerPhone = customerDto.CustomerPhone,
                    BankCard = customerDto.BankCard == null ? new BankCardPostDto() : new Model.BankCardItems.BankCardPostDto
                     {
                      CardNumber = customerDto.BankCard.CardNumber,
                      ExpireTime = customerDto.BankCard.ExpireTime
                     },
                    branches = customerDto.branches == null ? new List<Model.BranchItems.BranchPostDto>() : customerDto.branches.Select(b => new Model.BranchItems.BranchPostDto
                    {
                        BranchName = b.BranchName,
                        BranchLocation = b.BranchLocation
                    }).ToList()
                };
            }
        }
        public void postcustomer(CustomerPostDto customerDto)
        {
            Customer customer = new Customer
            {
                accounts = customerDto.accounts.Select(a => new Model.Accountitems.Account
                {
                    AccountNumber = a.AccountNumber,
                    Balance = a.Balance
                }).ToList(),
                BankCard = new Model.BankCardItems.BankCard
                {
                    CardNumber = customerDto.BankCard.CardNumber,
                    ExpireTime = customerDto.BankCard.ExpireTime,
                },
                CustomerEmail = customerDto.CustomerEmail,
                CustomerName = customerDto.CustomerName,
                CustomerPhone = customerDto.CustomerPhone
                ,
                branches = customerDto.branches.Select(b => new Model.BranchItems.Branch
                {
                    BranchName = b.BranchName,
                    BranchLocation = b.BranchLocation
                }).ToList()
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
}
