using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_ASP.NET_Identity.Startup))]
namespace Demo_ASP.NET_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
