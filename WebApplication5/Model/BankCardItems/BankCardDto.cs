namespace WebApplication4.Model.BankCardItems
{
    public class BankCardDto
    {
    }
    public class BankCardPostDto
    {
        public string CardNumber { get; set; } = string.Empty;
        public DateTime ExpireTime { get; set; } = DateTime.Now;
    }
}
