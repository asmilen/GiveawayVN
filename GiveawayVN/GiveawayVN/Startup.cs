using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiveawayVN.Startup))]
namespace GiveawayVN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
