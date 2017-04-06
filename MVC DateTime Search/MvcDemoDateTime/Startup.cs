using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDemoDateTime.Startup))]
namespace MvcDemoDateTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
