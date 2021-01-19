using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PomodoroApplication.Startup))]
namespace PomodoroApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
