using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PingToCode.UI.Startup))]
namespace PingToCode.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
