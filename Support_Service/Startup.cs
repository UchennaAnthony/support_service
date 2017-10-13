using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Support_Service.Startup))]
namespace Support_Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
