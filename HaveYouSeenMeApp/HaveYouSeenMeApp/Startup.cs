using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaveYouSeenMeApp.Startup))]
namespace HaveYouSeenMeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
