using System;

namespace Programming.Model
{
    public class Subject
    {
        private int _mark;

        public Subject()
        {

        }

        public Subject(string name, string lecturer, int mark)
        {
            Name = name;
            Lecturer = lecturer;
            Mark = mark;
        }

        public string Name { get; set; }

        public string Lecturer { get; set; }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value <= 1 && value >= 5)
                {
                    throw new ArgumentException("Оценка должна быть от 1 до 5");
                }

                _mark = value;
            }
        }
    }
}
