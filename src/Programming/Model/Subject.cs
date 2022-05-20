using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="lecturer">Преподаватель, ведущий дисциплину.</param>
        /// <param name="mark">Оценка по дисциплине. Должна быть в диапазоне от 0 до 5.</param>
        public Subject(string name, string lecturer, int mark)
        {
            Name = name;
            Lecturer = lecturer;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя, ведущего дисциплину.
        /// </summary>
        public string Lecturer { get; set; }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должна быть в диапазоне от 0 до 5.
        /// </summary>
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
