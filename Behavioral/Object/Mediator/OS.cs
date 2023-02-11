namespace Mediator
{
    public class OS
    {
        public void ExecuteService( Service service )
        {
            System.Console.WriteLine($"----------- Executing Service: {service.Name} ------------");
        }

    }
}