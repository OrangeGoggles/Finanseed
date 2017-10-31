using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finanseed.Presentation.Startup))]
namespace Finanseed.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
