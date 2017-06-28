using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BotanikaLabs.Startup))]
namespace BotanikaLabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
