using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuongTinShop.Startup))]
namespace DuongTinShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
