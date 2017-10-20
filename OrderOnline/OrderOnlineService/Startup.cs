using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OrderOnlineService.Startup))]

namespace OrderOnlineService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}