using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Work_Flow.Application.Interfaces.Services;
namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        public AccountController(IAccountService accountService ) {
        _accountService= accountService;    
        }

        [HttpGet]
        
        public IActionResult Login()
        {
            var result = _accountService.Login();
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);

        }
    }
}
