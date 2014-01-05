using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SillyTest.Startup))]
namespace SillyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
