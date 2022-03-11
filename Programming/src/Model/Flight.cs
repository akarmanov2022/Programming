using System;

namespace Programming.Model
{
    public class Flight
    {
        private int _time;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public Flight()
        {
        }

        public Flight(int time, string departure, string destination)
        {
            Time = time;
            Departure = departure;
            Destination = destination;
        }

        public int Time
        {
            get => _time;
            set => _time = value < 0 ? throw new ArgumentException($"Time < 0: {value}") : value;
        }
    }
}