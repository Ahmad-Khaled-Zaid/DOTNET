using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Microsoft.AspNetCore.Http;
namespace Registration.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly RegistrationContext _context;
        public LoginController(RegistrationContext _context)
        {
            this._context = _context;
        }

        [HttpPost]
        [Route("log")]
        public async Task<IActionResult> userLogin()
        {
            return Ok("you are in");
        }

    }


}
