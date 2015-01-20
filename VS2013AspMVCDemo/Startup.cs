using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VS2013AspMVCDemo.Startup))]
namespace VS2013AspMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
