using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blakeit.RunBet.Startup))]
namespace Blakeit.RunBet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
