using Microsoft.AspNetCore.Mvc;

namespace BodyForceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly BodyForceContext _context;
        public UserController(BodyForceContext context)
        {
            _context = context;
        }
        [Route("/api/AddUser")]
        [HttpPost]
        public async Task<IActionResult> AddUser(Users model)
        {
           await _context.User.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }
    }
}
