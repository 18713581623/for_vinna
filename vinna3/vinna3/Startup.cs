using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vinna3.Startup))]
namespace vinna3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
