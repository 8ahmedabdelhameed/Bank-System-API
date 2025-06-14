using WebApplication4.IRepo;
using WebApplication4.Model.AccountItems;
using WebApplication4.Model.BranchItems;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Rep
{
    public class BranchRepo : IBranchRepo
    {
        private readonly AppDbContext _context;

        public BranchRepo(AppDbContext context)
        {
            _context = context;
        }

        public void DeleteBranch(int id)
        {
            var branch = _context.Branches.FirstOrDefault(b => b.BranchId == id);
            if (branch != null)
            {
                _context.Branches.Remove(branch);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Branch not found");
            }
        }

        public List<BranchGetsDto> GetBranchById()
        {
            return _context.Branches == null ? null : _context.Branches.Select(b => new BranchGetsDto
            {
                BranchName = b.BranchName,
                BranchLocation = b.BranchLocation,
                customers = b.customers == null ? new List<CustomerGetssDto>() : b.customers.Select(c => new CustomerGetssDto
                {
                    CustomerName = c.CustomerName,
                    CustomerEmail = c.CustomerEmail,
                    CustomerPhone = c.CustomerPhone,
                    accounts = c.accounts == null ? new List<AccountPostDto>() : c.accounts.Select(a => new AccountPostDto
                    {
                        AccountNumber = a.AccountNumber,
                        Balance = a.Balance
                    }).ToList(),
                }).ToList()
            }).ToList();
        }
        public void PostBranch(BranchPostsDto branchPostDto)
        {
            Branch branch = new Branch
            {
                BranchName = branchPostDto.BranchName,
                BranchLocation = branchPostDto.BranchLocation,
                customers = branchPostDto.branches.Select(c => new Customer
                {
                    CustomerName = c.CustomerName,
                    CustomerEmail = c.CustomerEmail,
                    CustomerPhone = c.CustomerPhone,
                    BankCard = c.BankCard == null ? null : new Model.BankCardItems.BankCard
                    {
                        CardNumber = c.BankCard.CardNumber,
                        ExpireTime = c.BankCard.ExpireTime
                    },
                }).ToList()
            };
        }

        public void UpdateBranch(BranchUpdateDto branchUpdateDto , int id)
        {
            var branch = _context.Branches.FirstOrDefault(b => b.BranchId == id);
            if (branch != null)
            {
                branch.BranchName = branchUpdateDto.BranchName;
                branch.BranchLocation = branchUpdateDto.BranchLocation;
                branch.customers = _context.Customers.Where(c => branchUpdateDto.Customers.Contains(c.CustomerId)).ToList() == null ? new List<Customer>() : _context.Customers.Where(c => branchUpdateDto.Customers.Contains(c.CustomerId)).ToList();
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Branch not found");
            }
        }
    }
}
