using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroduccionAMSCognitiveServices.Startup))]
namespace IntroduccionAMSCognitiveServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
