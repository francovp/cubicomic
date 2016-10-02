using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cubicomic.Startup))]
namespace cubicomic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
