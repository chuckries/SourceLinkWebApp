using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SourceLinkWebApp.Startup))]
namespace SourceLinkWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
