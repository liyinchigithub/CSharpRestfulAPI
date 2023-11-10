using Microsoft.EntityFrameworkCore;

namespace CSharpRestfulAPI;

// 数据库上下文类
public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("YourConnectionString"); // 替换为您的MySQL连接字符串
    }
}