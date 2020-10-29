using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gen_Repo_Pattern.Startup))]
namespace Gen_Repo_Pattern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
