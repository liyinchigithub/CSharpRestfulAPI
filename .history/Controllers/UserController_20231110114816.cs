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
        var users = _dbContext.User.ToList();
        return Ok(users);
    }
}