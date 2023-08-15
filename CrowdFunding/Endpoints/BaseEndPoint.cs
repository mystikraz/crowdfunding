namespace CrowdFunding.Endpoints
{
    public class BaseEndPoint
    {
        public string baseUrl = "/api/v1/";
        public string url;

        public virtual void MapEndPoints(WebApplication app)
        {

        }
    }
}
