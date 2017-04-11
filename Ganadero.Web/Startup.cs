using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ganadero.Web.Startup))]
namespace Ganadero.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
