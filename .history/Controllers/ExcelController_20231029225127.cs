using Microsoft.AspNetCore.Mvc;

namespace CSharpRestfulAPI.Controllers
{
    [Route("api/excel")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        // 在这里定义处理Excel相关请求的方法

        [HttpGet("read")]
        public IActionResult ReadExcel()
        {
            // 处理读取Excel的逻辑
            // 返回一个json
            
            return Ok();
        }

        [HttpPost("write")]
        public IActionResult WriteExcel()
        {
            // 处理写入Excel的逻辑
            return Ok();
        }
    }
}