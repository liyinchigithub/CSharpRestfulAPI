using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model, [FromHeader(Name = "YourHeaderName")] string yourHeader)
        {
            // 使用model和yourHeader进行操作
            string username = model.Username;
            string password = model.Password;

            // 操作逻辑...

            // 返回操作结果作为响应体
            var result = Ok(new { code = 0, msg = "success", data = new { userId = 1, userName = "liyinchi" } });
            // 调试输出
            Console.WriteLine("yourHeader",yourHeader);
            Console.WriteLine("model",model);
            return Ok(result);
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // 处理退出逻辑
            // mock返回一个json数据
            return Ok(new { code = 0, msg = "success", data = "" });
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            // 处理注册逻辑
            // ...
            return Ok(new { code = 0, msg = "success", data = new { userId = 1, userName = "liyinchi", datetime = "2023-11-09 12:00:00" } });
        }
    }
}