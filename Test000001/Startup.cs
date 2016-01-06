using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test000001.Startup))]
namespace Test000001
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
