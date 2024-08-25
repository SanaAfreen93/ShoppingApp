using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopCart.Application.Dto;
using ShopCart.Application.Interface;

namespace ShopCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ILoginInterface _loginInterface;


        public LoginController(ILoginInterface loginService)
        {
            _loginInterface = loginService;
        }

       [HttpPost("login")]
       public IActionResult Login(UserDto users)
       {
            var Data = _loginInterface.login(users);
                    return Ok(Data);

        }

        [HttpPost("createuser")]
        public async  Task<IActionResult> CreateUser(UserDto users)
        {
            var Data = await _loginInterface.SaveUserDetails(users);
            return   Ok(Data);

        }
    }
}
