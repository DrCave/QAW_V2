using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QAW_V2.Startup))]
namespace QAW_V2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
