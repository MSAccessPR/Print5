using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Print5.Startup))]
namespace Print5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
