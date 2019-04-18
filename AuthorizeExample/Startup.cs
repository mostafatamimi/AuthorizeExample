using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorizeExample.Startup))]
namespace AuthorizeExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
