using Maomi;
using Maomi.Web.Core;

namespace Demo9.ExceptionFilter
{
    [InjectModule<MaomiWebModule>()]
    public class ApiModule : IModule
    {
        public void ConfigureServices(ServiceContext context)
        {
        }
    }
}
