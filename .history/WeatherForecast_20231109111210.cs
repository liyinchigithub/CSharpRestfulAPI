namespace CSharpRestfulAPI; // 声明了命名空间CSharpRestfulAPI。

/**
* @author liyinchi
* @description 定义了一个名为WeatherForecast的公共类
* 
*/
public class WeatherForecast
{
    // 日期
    public DateOnly Date { get; set; }

    // 摄氏温度
    public int TemperatureC { get; set; }

    // 华氏温度，通过摄氏温度计算得出
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    // 天气摘要
    public string? Summary { get; set; }
}
