using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hola_Mundo.Startup))]
namespace Hola_Mundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
