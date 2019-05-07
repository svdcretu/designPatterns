using System.Collections.Generic;

using FlyWeightUsage.Repository;

namespace FlyWeightUsage
{
    public interface IMicrosericeConnectorFactory
    {
        IMicroserviceConnector GetConnector(string target);
    }

    public class MicrosericeConnectorFactory : IMicrosericeConnectorFactory
    {
        private Dictionary<string, IMicroserviceConnector> _microserviceConnectors;

        private IMicroserviceRepository _microserviceRepository;

        public MicrosericeConnectorFactory(IMicroserviceRepository microserviceRepository)
        {
            _microserviceConnectors = new Dictionary<string, IMicroserviceConnector>();
            _microserviceRepository = microserviceRepository;
        }

        public IMicroserviceConnector GetConnector(string target)
        {
            if (_microserviceConnectors.ContainsKey(target))
            {
                return _microserviceConnectors[target];
            }
            var microserviceConnector = new MicroserviceConnector(_microserviceRepository, target);
            _microserviceConnectors.Add(target, microserviceConnector);

            return microserviceConnector;
        }
    }
}
