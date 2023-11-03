using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace CSharpRestfulAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // 加载appsettings.json文件
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // 设置基础路径为当前目录
                .AddJsonFile("appsettings.json") // 添加appsettings.json文件
                .Build(); // 构建配置对象

            // 将配置项注册为服务，以便在应用程序中使用
            // services.Configure<LoggingOptions>(configuration.GetSection("Logging")); // 注册LoggingOptions服务，并绑定appsettings.json中的Logging配置节
            // services.Configure<ConnectionStringsOptions>(configuration.GetSection("ConnectionStrings")); // 注册ConnectionStringsOptions服务，并绑定appsettings.json中的ConnectionStrings配置节
            // services.Configure<AppSettingsOptions>(configuration.GetSection("AppSettings")); // 注册AppSettingsOptions服务，并绑定appsettings.json中的AppSettings配置节
            // services.Configure<AuthenticationOptions>(configuration.GetSection("Authentication")); // 注册AuthenticationOptions服务，并绑定appsettings.json中的Authentication配置节
            // services.Configure<CacheOptions>(configuration.GetSection("Cache")); // 注册CacheOptions服务，并绑定appsettings.json中的Cache配置节
            // services.Configure<FileUploadOptions>(configuration.GetSection("FileUpload")); // 注册FileUploadOptions服务，并绑定appsettings.json中的FileUpload配置节
            // services.Configure<EmailOptions>(configuration.GetSection("Email")); // 注册EmailOptions服务，并绑定appsettings.json中的Email配置节
            // 允许跨域
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
            // 其他服务的注册和配置...
             services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // 应用程序的其他配置...
         app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}