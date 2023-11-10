using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers;


// 控制器类
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly MyDbContext _dbContext;

    public UserController(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _dbContext.Users.ToList();
        return Ok(users);
    }


    [HttpPost("register")]
    public IActionResult RegisterUser(User user)
    {
        // 处理注册逻辑
        // 将用户数据插入到数据库表中
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();

        return Ok("User registered successfully");
        return Ok(new { code = 0, msg = "success", data = new { userId = 1, userName = "liyinchi", datetime = "2023-11-09 12:00:00" } });
    }

}