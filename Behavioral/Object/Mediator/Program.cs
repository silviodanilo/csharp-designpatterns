using Mediator;

Service service = new("ServiceX");
OS oS = new();
VirusScanMediator virusScanMediator = new(oS);
Client client = new(virusScanMediator);

// Try Execute Service
for (int i = 0; i < 10; i++)
    client.ExecuteService(service);


