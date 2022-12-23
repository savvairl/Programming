using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Предоставляет реализацию накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Баллы.
        /// </summary>
        private int _points;

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {

        }

        /// <summary>
        /// Возвращает и задает количество баллов. Должно быть не меньше нуля.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(nameof(Points), value);
                _points = value;
            }
        }

        /// <summary>
        /// Возвращает информацию по количеству баллов.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        /// <summary>
        /// Высчитывает скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает общую стоимость товаров с учетом скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;

            foreach (var item in items)
            {
                amount += item.Cost;
            }

            if (_points <= (int)(amount * 0.3))
            {
                return _points;
            }
            else if (_points > (int)(amount * 0.3))
            {
                return Math.Ceiling(amount * 0.3);
            }

            return 0;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает скидку.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= (int)discount;

            return discount;
        }

        /// <summary>
        /// Высчитывает новое количество скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }

            _points += (int)Math.Ceiling(amount * 0.1);
        }

        public int CompareTo(PointsDiscount other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }

            return Points.CompareTo(other.Points);
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return 0;
            }
            if (ReferenceEquals(null, obj))
            {
                return 1;
            }
            if (obj is PointsDiscount other)
            {
                return CompareTo(other);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
