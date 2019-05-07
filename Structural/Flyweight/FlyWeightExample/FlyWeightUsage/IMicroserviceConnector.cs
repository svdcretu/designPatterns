namespace FlyWeightUsage
{
    public interface IMicroserviceConnector
    {
        string Url { get; set; }

        string ConnectionTarget { get; set; }

        int Counter { get; }

        string GetConnectionInfo(int userId, int applicationId);
    }
}
