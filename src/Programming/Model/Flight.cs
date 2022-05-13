using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _time;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        /// <param name="departurePoint">Место отправления.</param>
        /// <param name="destinationPoint">Место прибытия.</param>
        /// <param name="time">Время полёта в минутах. Должно быть положительным числом.</param>
        public Flight(string departurePoint, string destinationPoint, int time)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            Time = time;
        }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Time), value);
                _time = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }
    }
}
