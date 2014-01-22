using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebPublishAzure.Startup))]
namespace HelloWebPublishAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
