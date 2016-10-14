using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalOgloszeniowy.Startup))]
namespace PortalOgloszeniowy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
