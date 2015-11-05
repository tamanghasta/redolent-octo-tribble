using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(responsive_tutorials.Startup))]
namespace responsive_tutorials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
