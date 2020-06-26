using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeziDunyam.Startup))]
namespace GeziDunyam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
