using Demo1.Application;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Api.Controllers;

/// <summary>
/// 接口的标识
/// </summary>
[ApiController]
//路径
[Route("[controller]")]
public class IndexController : ControllerBase
{

    private readonly IMyService _service;

    public IndexController(IMyService service)
    {
        _service = service;
    }

    /// <summary>
    /// HttpGet：任务标识
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [HttpGet(Name = "sum")]
    public int Get(int a, int b)
    {
        return _service.Sum(a, b);
    }
}