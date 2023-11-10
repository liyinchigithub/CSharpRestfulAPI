using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

// 创建一个WebApplication构建器对象
var builder = WebApplication.CreateBuilder(args);


// 添加ExcelController到路由配置
// 将"控制器服务"添加到应用程序的服务容器中
builder.Services.AddControllers();
// 将"API浏览器服务"添加到应用程序的服务容器中
builder.Services.AddEndpointsApiExplorer();
// 将Swagger生成器服务添加到应用程序的服务容器中
builder.Services.AddSwaggerGen();// swagger控制器
builder.Services.AddRazorPages();//
builder.Services.AddDbContext<MyDbContext>();// 数据库Mysql控制器（路由）

// 使用构建器对象构建一个WebApplication实例
var app = builder.Build();

// 如果应用程序处于开发环境，则启用Swagger和Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 将HTTP请求重定向到HTTPS
app.UseHttpsRedirection();

// 允许跨域配置
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});
// 启用“身份验证”和“授权”中间件
app.UseAuthorization();

// 将“控制器路由”添加到应用程序的请求处理管道中
app.MapControllers();// 我们使用 app.MapControllers() 方法将 ExcelController 添加到路由配置中。这将使得 ExcelController 中的路由路径能够被正确地映射和处理

// 运行应用程序，开始监听和处理HTTP请求
app.Run();