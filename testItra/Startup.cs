using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testItra.Startup))]
namespace testItra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
