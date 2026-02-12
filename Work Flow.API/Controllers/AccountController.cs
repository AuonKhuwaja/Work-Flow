using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work_Flow.Application.Common.Interfaces;
using Work_Flow.Application.Interfaces.Services;
namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        private IJwtTokenGenerator _jwtTokenGenerator;
        public AccountController(IAccountService accountService, IJwtTokenGenerator jwtTokenGenerator ) {
        _accountService= accountService;    
        _jwtTokenGenerator= jwtTokenGenerator;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            var user = await _accountService.LoginAsync(); 

            if (user == null)
                return Unauthorized("Invalid credentials");

            var token = _jwtTokenGenerator.GenerateToken(user);

            return Ok(new
            {
                token = token
            });
        }



    }
}
