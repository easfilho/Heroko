using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Heroko.Startup))]
namespace Heroko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
