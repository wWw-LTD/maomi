using Demo1.Api;
using Maomi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//使用 API 控制器（Controller）这种模式来处理 HTTP 请求
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//要生成 API 文档，请帮我收集所有 API 接口的信息
builder.Services.AddEndpointsApiExplorer();

//请用 Swagger 格式，把刚才收集到的所有 API 信息，生成一份结构化的 JSON 文档
builder.Services.AddSwaggerGen();

// 注册模块化服务，并设置 ApiModule 为入口
//告诉框架从哪个模块开始加载
builder.Services.AddModule<ApiModule>();

////DI 容器在你调用 builder.Build() 之后，按需自动创建的ApiModule
var app = builder.Build();

// Configure the HTTP request pipeline.

//区分开发环境
if (app.Environment.IsDevelopment())
{
    //访问 /swagger/v1/swagger.json
    app.UseSwagger();
    //访问 /swagger
    app.UseSwaggerUI();
}

//检测是否有权限进入
app.UseAuthorization();

//它负责将传入的 HTTP 请求（比如 GET /Index?sum?a=1&b=2），根据 URL 和 HTTP 方法，路由（映射）到正确的 Controller 和 Action 上。
app.MapControllers();

app.Run();
