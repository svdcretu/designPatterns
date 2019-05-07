using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

using FlyWeightUsage;
using FlyWeightUsage.Repository;

namespace FlyWeightExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMicroserviceRepository microserviceRepository = new MicroserviceRepository();
            IMicrosericeConnectorFactory factory = new MicrosericeConnectorFactory(microserviceRepository);

            var targets = new List<string> { "userMicroservice", "ordersMicroservice",
                "userMicroservice", "productsMicroservice",
                "productsMicroservice", "ordersMicroservice" };

            int userId = 0;
            int applicationId = 0;
            foreach (string target in targets)
            {
                userId++;
                applicationId++;

                IMicroserviceConnector connector = factory.GetConnector(target);
                string connectionInfo = connector.GetConnectionInfo(userId, applicationId);
                Console.WriteLine($" {target} connection info : {connectionInfo} - the shared counter: {connector.Counter}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
