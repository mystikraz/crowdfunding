using CrowdFunding.Endpoints;
using Repository;

namespace CrowdFunding.Extension
{
    public static class ConfigureDependency
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<BaseEndPoint, CampaignEndpoints>();
            services.AddScoped<BaseEndPoint, UserEndPoints>();
            services.AddScoped<BaseEndPoint, DonationEndpoints>();
            services.AddScoped<BaseEndPoint, CommentEndpoints>();


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
