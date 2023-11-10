
namespace CSharpRestfulAPI;

// 数据模型类
public class User
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public bool? isEnalbe { get; set; }
    public DateTime? created { get; set; }
}