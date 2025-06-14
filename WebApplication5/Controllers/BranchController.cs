using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.IRepo;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepo _branchRepo;

        public BranchController(IBranchRepo branchRepo)
        {
            _branchRepo = branchRepo;
        }
        [HttpPost]
        public IActionResult PostBranch([FromBody] Model.BranchItems.BranchPostsDto branchPostDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.ValidationState);
            }
            else
            {
                _branchRepo.PostBranch(branchPostDto);
                return Created();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBranch(int id)
        {
            try
            {
                _branchRepo.DeleteBranch(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Branch not found");
            }
        }
        [HttpPut]
        public IActionResult UpdateBranch([FromBody] Model.BranchItems.BranchUpdateDto branchUpdateDto, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.ValidationState);
            }
            else
            {
                _branchRepo.UpdateBranch(branchUpdateDto, id);
                return NoContent();
            }
        }
        [HttpGet("Get")]
        public IActionResult GetAllBranch()
        {
            var branches = _branchRepo.GetBranchById();
            if (branches == null || !branches.Any())
            {
                return NotFound("No branches found");
            }
            return Ok(branches);
        }
    }
}
