namespace Mediator
{
    public class Client
    {
        private VirusScanMediator? _virusScanMediator;

        public Client(VirusScanMediator virusScanMediator)
        {
            _virusScanMediator = virusScanMediator;
        }
        public void ExecuteService(Service service)
        {
            bool oK = _virusScanMediator!.ExecuteService(service);

            if ( oK )
                System.Console.WriteLine($"Service {service.Name} Executed ");
            else
                System.Console.WriteLine($"Service {service.Name} Not Executed ");

        }

    }
}