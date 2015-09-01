using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeedBaseIndia.Startup))]
namespace NeedBaseIndia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
