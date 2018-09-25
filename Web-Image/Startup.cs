using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Image.Startup))]
namespace Web_Image
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
