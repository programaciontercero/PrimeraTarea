using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tienda.Startup))]
namespace tienda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
