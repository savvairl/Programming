﻿namespace Programming.Model
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
                if (value >= 0)
                {
                    _time = value;
                }
                else
                {
                    throw new System.ArgumentException("Значение должно быть больше нуля");
                }
            }
        }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
    }
}
