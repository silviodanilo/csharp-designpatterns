using Observer;

Flight f1 = new Flight("Flight 01",FlightSituation.OntTime);
Airport a1 = new Airport("Brasilia",f1);
Airport a2 = new Airport("Recife",f1);
Airport a3 = new Airport("Manaus",f1);

f1.ModifyFlightSituation(FlightSituation.Delayed);
f1.ModifyFlightSituation(FlightSituation.Canceled);


