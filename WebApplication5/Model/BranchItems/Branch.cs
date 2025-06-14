using System.ComponentModel.DataAnnotations;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Model.BranchItems
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; } 
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
        public List<Customer> customers { get; set; } = new List<Customer>();


    }
}
