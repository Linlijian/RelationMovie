using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RelationMovie.Startup))]
namespace RelationMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
