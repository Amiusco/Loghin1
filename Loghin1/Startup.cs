using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loghin1.Startup))]
namespace Loghin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
