using System;

namespace Mediator
{
    public class VirusScanMediator
    {
        private OS? _oS;

        public VirusScanMediator(OS oS)
        {
            this._oS = oS;
        }
        private bool HasVirus(Service service)
        {
            //Simulate Virus
            int seed = DateTime.Now.Millisecond;
            Random rand = new Random(seed);
            int virus = rand.Next(2);
            return virus == 0 ? false : true;
        }
        public bool ExecuteService(Service service)
        {
            if (!HasVirus(service))
            {
                System.Console.WriteLine($"The Service {service.Name} does not have Virus!!");
                _oS?.ExecuteService(service);
                return true;
            }
            else
            {
                System.Console.WriteLine($"The Service {service.Name} has Virus!!");
                return false;
            }
        }
    }
}