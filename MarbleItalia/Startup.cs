using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarbleItalia.Startup))]
namespace MarbleItalia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
