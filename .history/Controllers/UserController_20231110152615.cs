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
        // 处理注册逻辑
        // 将用户数据插入到数据库表中
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        string userName = user.name; // 获取注册成功后的用户名称
        return Ok(new { code = 0, msg = "success", data = new {userName = userName" ,datetime = "2023-11-09 12:00:00" } });
    }

}