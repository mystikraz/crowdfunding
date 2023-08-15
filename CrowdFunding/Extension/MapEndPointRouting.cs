using CrowdFunding.Endpoints;

namespace CrowdFunding.Extension
{
    public class MapEndPointRouting
    {
        public static void MapEndpoints(WebApplication app)
        {
            using(var scope=app.Services.CreateScope())
            {
                var services = scope.ServiceProvider.GetServices<BaseEndPoint>();

                foreach (var service in services)
                {
                    service.MapEndPoints(app);
                }
            }
        }
    }
}
