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
                Validator.AssertValueInRange(nameof(Mark), value, 1, 5);
                _mark = value;
            }
        }
    }
}
