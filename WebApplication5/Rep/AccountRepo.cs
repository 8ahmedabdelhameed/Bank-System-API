using WebApplication4.IRepo;
using WebApplication4.Model.Accountitems;
using WebApplication4.Model.AccountItems;

namespace WebApplication4.Rep
{
    public class AccountRepo : IAccountRepo
    {
        private readonly AppDbContext _context;
        public void PostAccount(AccountPostDtoWithCustomer accountPostDtoWithCustomer)
        {
            Account account = new Account
            {
                AccountNumber = accountPostDtoWithCustomer.AccountNumber,
                Balance = accountPostDtoWithCustomer.Balance,
                Customer = _context.Customers.FirstOrDefault(c => c.CustomerId == accountPostDtoWithCustomer.CustomerId) == null ? null : _context.Customers.FirstOrDefault(c => c.CustomerId == accountPostDtoWithCustomer.CustomerId)
            };
            _context.accounts.Add(account);
            _context.SaveChanges();
        }

    }
}
