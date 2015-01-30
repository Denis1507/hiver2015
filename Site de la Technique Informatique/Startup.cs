using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Site_de_la_Technique_Informatique.Startup))]
namespace Site_de_la_Technique_Informatique
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
