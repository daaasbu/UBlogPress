using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UBlogPress.Startup))]
namespace UBlogPress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
