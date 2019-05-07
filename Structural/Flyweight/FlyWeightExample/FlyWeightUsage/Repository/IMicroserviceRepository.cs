namespace FlyWeightUsage.Repository
{
    public interface IMicroserviceRepository
    {
        string GetConnectionTarget(string target);

        string GetUrl(string target);
    }
}