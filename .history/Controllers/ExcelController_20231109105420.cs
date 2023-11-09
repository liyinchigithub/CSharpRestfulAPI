using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers
{

    /**
    * 发送GET请求到http://localhost:5029/api/excel来访问该接口
    */
    [Route("api/excel")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        // 在这里定义处理Excel相关请求的方法

        [HttpGet("read")]
        public IActionResult ReadExcel()
        {
            // 处理读取Excel的逻辑
            // 模拟读取 Excel 数据
            var excelData = new { Name = "John", Age = 30 };

            // 返回 JSON 格式的数据
            return new JsonResult(excelData);
        }

        [HttpPost("write")]
        public IActionResult WriteExcel()
        {
            // 处理写入Excel的逻辑
            // 模拟写入 Excel 数据
            var result = new { Success = true, Message = "Data written successfully" };

            // 返回 JSON 格式的数据
            return new JsonResult(result);
        }
    }
}