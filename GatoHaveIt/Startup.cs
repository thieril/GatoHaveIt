using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GatoHaveIt.Startup))]
namespace GatoHaveIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
