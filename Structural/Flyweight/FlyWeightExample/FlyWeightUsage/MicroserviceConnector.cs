using FlyWeightUsage.Repository;

namespace FlyWeightUsage
{
    public class MicroserviceConnector: IMicroserviceConnector
    {
        public string Url { get; set; }

        public string ConnectionTarget { get; set; }

        public MicroserviceConnector(IMicroserviceRepository repository, string target)
        {
            Url = repository.GetUrl(target);
            ConnectionTarget = repository.GetConnectionTarget(target);
            Counter = 0;
        }

        public int Counter { get; private set; }

        public string GetConnectionInfo(int userId, int applicationId)
        {
            Counter++;
            string connectionInfo = $"{Url}/{ConnectionTarget}/{userId}/{applicationId}";
            return connectionInfo;
        }
    }
}
