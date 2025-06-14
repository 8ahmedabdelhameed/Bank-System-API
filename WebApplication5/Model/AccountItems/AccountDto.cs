namespace WebApplication4.Model.AccountItems
{
    public class AccountDtos
    {
    }
    public class AccountPostDto
    {
        public string AccountNumber { get; set; } = string.Empty;
        public int Balance { get; set; }
    }
    public class AccountPostDtoWithCustomer
    {
        public string AccountNumber { get; set; } = string.Empty;
        public int Balance { get; set; }
        public int CustomerId { get; set; } // Assuming CustomerId is an integer
    }
}
