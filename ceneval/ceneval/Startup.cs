using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ceneval.Startup))]
namespace ceneval
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
