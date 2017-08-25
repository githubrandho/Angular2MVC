using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular2MVCDemo.Startup))]
namespace Angular2MVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
