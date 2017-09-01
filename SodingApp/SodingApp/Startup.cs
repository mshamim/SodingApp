using Microsoft.Owin;
using Owin;
using System.Globalization;

[assembly: OwinStartupAttribute(typeof(SodingApp.Startup))]
namespace SodingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);

            var cultureInfo = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }
}
