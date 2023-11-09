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
            // mock返回一个json数据
            return Ok(new { code = 0,msg="success",data= {userId=1,userName="liyinchi"}});
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // 处理退出逻辑
            // mock返回一个json数据


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