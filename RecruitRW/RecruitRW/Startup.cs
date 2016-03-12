using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecruitRW.Startup))]
namespace RecruitRW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
