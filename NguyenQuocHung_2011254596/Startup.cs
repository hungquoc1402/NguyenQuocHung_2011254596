using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenQuocHung_2011254596.Startup))]
namespace NguyenQuocHung_2011254596
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
