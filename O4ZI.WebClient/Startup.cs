using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(O4ZI.WebClient.Startup))]
namespace O4ZI.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
