using System;

namespace Programming.Model
{
    public class Song
    {
        private int _duration;

        public string Name { get; set; }

        public string ArtistName { get; set; }

        public Song()
        {
        }

        public Song(int duration, string name, string artistName)
        {
            Duration = duration;
            Name = name;
            ArtistName = artistName;
        }

        public int Duration
        {
            get => _duration;
            set => _duration = value < 0 ? throw new ArgumentException($"Width < 0: {value}") : value;
        }
    }
}