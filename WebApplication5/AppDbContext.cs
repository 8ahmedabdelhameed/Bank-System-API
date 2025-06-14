using Microsoft.EntityFrameworkCore;
using WebApplication4.Model.Accountitems;
using WebApplication4.Model.BankCardItems;

namespace WebApplication4
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Model.CustomerItems.Customer> Customers { get; set; }
        public DbSet<Model.BankCardItems.BankCard> BankCards { get; set; }
        public DbSet<Model.BranchItems.Branch> Branches { get; set; }
        public DbSet<Model.Accountitems.Account> accounts { get; set; }
    }
}
