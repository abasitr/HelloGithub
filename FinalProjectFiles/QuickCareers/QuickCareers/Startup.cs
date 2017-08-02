using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickCareers.Startup))]
namespace QuickCareers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
