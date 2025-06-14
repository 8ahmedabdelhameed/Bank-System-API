using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Model.BranchItems
{
    public class BranchPostsDto
    {
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
        public List<CustomerPostsDto> ? branches { get; set; } = new List<CustomerPostsDto>();
    }
    public class BranchGetsDto
    {
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
        public List<CustomerGetssDto>? customers { get; set; } = new List<CustomerGetssDto>();
    }
    public class BranchUpdateDto
    {
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
        public List<int> Customers { get; set; } = new List<int>();
    }
    public class BranchPostDto
    {
        public string BranchName { get; set; } = string.Empty;
        public string BranchLocation { get; set; } = string.Empty;
    }
}
