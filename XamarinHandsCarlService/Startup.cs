using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XamarinHandsCarlService.Startup))]

namespace XamarinHandsCarlService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}