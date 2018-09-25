using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi_Image.Startup))]
namespace WebApi_Image
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
