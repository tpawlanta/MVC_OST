using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovie_TPawlanta.Startup))]
namespace MvcMovie_TPawlanta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
