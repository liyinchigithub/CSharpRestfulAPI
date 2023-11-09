using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers;


  /**
    * 发送GET请求到发送GET请求到http://localhost:5029/WeatherForecast来访问该接口
    * 区别于ExcelController
    */
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // 数组
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    // 注意：路由路径是基于控制器的名称，而不是这里的Name！！！
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 4).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
