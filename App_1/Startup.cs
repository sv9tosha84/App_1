using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_1.Startup))]
namespace App_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
