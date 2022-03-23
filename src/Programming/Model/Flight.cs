namespace Programming.Model
{
    class Flight
    {
        public Flight()
        {

        }
        public Flight(string departurePoint, string destinationPoint)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
        }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
    }
}
