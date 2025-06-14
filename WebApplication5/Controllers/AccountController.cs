using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.IRepo;
using WebApplication4.Model.AccountItems;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _accountRepo;

        public AccountController(IAccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }
        [HttpPost]
        public IActionResult PostAccount([FromBody] AccountPostDtoWithCustomer accountPostDtoWithCustomer)
        { 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.ValidationState);
            }
            else
            {
                _accountRepo.PostAccount(accountPostDtoWithCustomer);
                return CreatedAtAction(nameof(PostAccount), new { id = accountPostDtoWithCustomer.AccountNumber }, accountPostDtoWithCustomer);
            }
        }
    }
}
