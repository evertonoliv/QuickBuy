using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Entity.Startup))]
namespace MVC_Entity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
