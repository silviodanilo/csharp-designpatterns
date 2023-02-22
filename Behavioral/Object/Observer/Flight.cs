namespace Observer
{
    public class Flight
    {
        public FlightSituation FlightSituation{ get; private set; }
        public readonly string Name;
        private Dictionary<string, Airport> _airports = new();

        public Flight( string name, FlightSituation flightSituation)
        {
            this.Name = name;
            this.FlightSituation = flightSituation;
        }

        public void Attach( Airport airport)
        {
            _airports.Add(airport.Name,airport);
        }
        public void Detach( Airport airport)
        {
            _airports.Remove(airport.Name);
        }

        public void Notify()
        {
            foreach( Airport a in _airports.Values)
            {
                a.Update(this);
            }
        }
        public void ModifyFlightSituation( FlightSituation flightSituation)
        {
            this.FlightSituation = flightSituation;
            this.Notify();
        }

    }
}