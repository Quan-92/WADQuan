using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WADQuan.Startup))]
namespace WADQuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
