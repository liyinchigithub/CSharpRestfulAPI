using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login()
        {
            // 处理登录逻辑
            // ...

            return Ok();
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // 处理退出逻辑
            // ...

            return Ok();
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            // 处理注册逻辑
            // ...

            return Ok();
        }
    }
}