using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work_Flow.Application.Interfaces.Services;

namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServices _userService;

        public UserController(IUserServices userServices)
        {
            _userService = userServices;
        }
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var users = _userService.GetUsersAsync();
            return Ok(users);
        }
    }

}
