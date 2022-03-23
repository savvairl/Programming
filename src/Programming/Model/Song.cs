namespace Programming.Model
{
    class Song
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
                if (value <= 0)
                {
                    throw new System.ArgumentException("Длительность должна быть больше нуля");
                }
                else
                {
                    _duration = value;
                }
            }
        }
    }
}
