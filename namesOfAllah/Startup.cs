using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(namesOfAllah.Startup))]
namespace namesOfAllah
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
