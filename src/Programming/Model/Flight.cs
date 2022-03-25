namespace Programming.Model
{
    class Flight
    {
        private int _time;
        public Flight()
        {

        }
        public Flight(string departurePoint, string destinationPoint, int time)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            Time = time;
        }
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _time = value;
                }
                else
                {
                    throw new System.ArgumentException("Время полёта должно быть от 0 до 60");
                }
            }
        }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
    }
}
