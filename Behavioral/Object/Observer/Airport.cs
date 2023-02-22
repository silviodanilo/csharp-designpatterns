namespace Observer
{
    public class Airport
    {
        private Dictionary<string, Flight> _flights = new();
        public readonly string Name;

        public Airport(string name, Flight flight)
        {
            this.Name = name;
            this._flights.Add(flight.Name, flight);
            this._flights[flight.Name].Attach(this);
        }
        public void Update( Flight flight)
        {
            this._flights[flight.Name] = flight;
            System.Console.WriteLine($"Airport: {this.Name}, Flight: {this._flights[flight.Name].Name}, Modified situation { this._flights[flight.Name].FlightSituation}");
        }

    }
}