using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bridgeport_Library.Startup))]
namespace Bridgeport_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
