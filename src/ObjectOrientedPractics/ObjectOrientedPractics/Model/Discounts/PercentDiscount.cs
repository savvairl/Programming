using System.Collections.Generic;
using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Предоставляет реализацию процентной скидки.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <summary>
        /// Возвращает и задает сумму заказа по категории.
        /// </summary>
        public double PurchaseAmount { get; set; }

        /// <summary>
        /// Возвращает и задает скидку.
        /// </summary>
        public int CurrentDiscount { get; set; } = 1;

        /// <summary>
        /// Возвращает информацию по скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная - <<{Category}>> - {CurrentDiscount}%";
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Вычисляет скидку для покупки.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает сумму скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            return amount * ((double)CurrentDiscount / 100);
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает сумму со скидкой.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Высчитывает новый процент скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }
            PurchaseAmount += amount;

            int newDiscount = (int)(PurchaseAmount / 100);
            if (newDiscount <= 10 && newDiscount != 0)
            {
                CurrentDiscount = newDiscount;
            }
            else if (newDiscount > 10)
            {
                CurrentDiscount = 10;
            }
        }

        public int CompareTo(PercentDiscount other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }
            if (ReferenceEquals(null, other))
            {
                return 1;
            }

            return CurrentDiscount.CompareTo(other.CurrentDiscount);
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
            if (obj is PercentDiscount other)
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
