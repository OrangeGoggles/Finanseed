using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finanseed.Presentation.Prototype.Startup))]
namespace Finanseed.Presentation.Prototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
