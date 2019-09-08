using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iCare.Presentation.MVC.Startup))]
namespace iCare.Presentation.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
