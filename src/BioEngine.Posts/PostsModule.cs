using BioEngine.Core.API;
using BioEngine.Core.Modules;
using BioEngine.Core.Search;
using BioEngine.Posts.Entities;
using BioEngine.Posts.Search;
using BioEngine.Posts.SiteMaps;
using cloudscribe.Web.SiteMap;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BioEngine.Posts
{
    public class PostsModule : BaseBioEngineModule
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration,
            IHostEnvironment environment)
        {
            base.ConfigureServices(services, configuration, environment);
            services.RegisterSearchRepositoryHook<Post>()
                .RegisterSearchProvider<PostsSearchProvider, Post>();
            services.AddScoped<ISiteMapNodeService, PostsSiteMapNodeService>();
            services.RegisterApiEntities<Post>();
        }
    }
}
