using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GesPharmWeb.Startup))]
namespace GesPharmWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
