using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PunchCreator.Startup))]
namespace PunchCreator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
