using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NegoshoePH.Web.Startup))]
namespace NegoshoePH.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
