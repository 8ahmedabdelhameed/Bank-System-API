using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.IRepo;
using WebApplication4.Model.CustomerItems;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
      private readonly ICustomerRepo _customerRepo;
        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpGet("Get")]
        public IActionResult GetCustomerById (int id)
        {
            var customer = _customerRepo.CustomerGetById(id);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult PostCustomer(CustomerPostDto customer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.ValidationState); 
            } else {
                _customerRepo.postcustomer(customer);
                return Created();
            }
        }
    }
}
