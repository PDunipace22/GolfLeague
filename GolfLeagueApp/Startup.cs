using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfLeagueApp.Startup))]
namespace GolfLeagueApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
