using Microsoft.AspNetCore.Mvc;

namespace Demo9.ActionFilter2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndexController : ControllerBase
    {
        [HttpPost("user")]
        public string GetUserName([FromBody] UserInfo info)
        {
            return info.Email.Split("@").FirstOrDefault();
        }
    }
}