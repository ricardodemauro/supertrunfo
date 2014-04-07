using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperTrunfo.Web.Startup))]
namespace SuperTrunfo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
