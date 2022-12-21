using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Количество товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара. Должно быть до 200 символов.</param>
        /// <param name="info">Информация о товаре. Должна быть до 1000 символов.</param>
        /// <param name="cost">Стоимость товара. От 0 до 100 000.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Name), 200, value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Name), 1000, value);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), 0, 100000, value);
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; }
    }
}
