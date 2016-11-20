using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviestore.Startup))]
namespace Moviestore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
