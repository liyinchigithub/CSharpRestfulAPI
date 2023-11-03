// 创建一个WebApplication构建器对象
var builder = WebApplication.CreateBuilder(args);

// 将"控制器服务"添加到应用程序的服务容器中
builder.Services.AddControllers();

// 将"API浏览器服务"添加到应用程序的服务容器中
builder.Services.AddEndpointsApiExplorer();

// 将Swagger生成器服务添加到应用程序的服务容器中
builder.Services.AddSwaggerGen();

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

// 启用“身份验证”和“授权”中间件
app.UseAuthorization();

// 将“控制器路由”添加到应用程序的请求处理管道中
app.MapControllers();

// 运行应用程序，开始监听和处理HTTP请求
app.Run();