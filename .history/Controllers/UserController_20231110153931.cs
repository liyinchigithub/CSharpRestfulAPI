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
    public IActionResult RegisterUser([FromBody] User user)
    {
         try
        {
        // 处理注册逻辑
        // 将用户数据插入到数据库表中
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        // 获取注册成功后的用户名称
        var userName = user.Name;
        // 返回
        return Ok(new { code = 0, msg = "success", data = new { user        );
        catch (Exception ex)
        {
            return BadRequest("Failed to register user: " + ex.Message);
        }
    }

}