using System;

namespace Programming.Model
{
    public class Song
    {
        private int _duration;

        public Song()
        {

        }

        public Song(string artist, string name, int duration)
        {
            Artist = artist;
            Name = name;
            Duration = duration;
        }

        public string Artist { get; set; }

        public string Name { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                _duration = value;
            }
        }
    }
}
