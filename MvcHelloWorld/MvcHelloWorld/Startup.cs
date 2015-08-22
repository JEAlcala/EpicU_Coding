using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcHelloWorld.Startup))]
namespace MvcHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
