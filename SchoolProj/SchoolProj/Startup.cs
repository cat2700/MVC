using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolProj.Startup))]
namespace SchoolProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
