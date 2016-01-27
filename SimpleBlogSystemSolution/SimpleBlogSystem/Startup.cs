using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBlogSystem.Startup))]
namespace SimpleBlogSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
