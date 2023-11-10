using Microsoft.EntityFrameworkCore;

namespace CSharpRestfulAPI;

// 数据库上下文类
public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=CSharpRestfulAPI;Uid=root;Pwd=123456;");// 替换为您的MySQL连接字符串
    }
}