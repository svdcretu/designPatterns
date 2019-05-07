

namespace FlyWeightUsage.Repository
{
    public class MicroserviceRepository: IMicroserviceRepository
    {
        public string GetConnectionTarget(string target)
        {
            return $"mongodb://db{target}";
        }

        public string GetUrl(string target)
        {
            return $"https:/{target}";
        }
    }
}
