using ObjectOrientedPractics.Services;
using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable, IComparable<Item>
    {
        public event EventHandler<EventArgs> NameChanged;

        public event EventHandler<EventArgs> InfoChanged;

        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Количество товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

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
            private set
            {
                _id = value;
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
                if (_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; }

        public object Clone()
        {
            Item item = new Item();
            item.Name = Name;
            item.Info = Info;
            item.Cost = Cost;
            item.Category = Category;
            item.Id = Id;
            return item;
        }

        public bool Equals(Item other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            return Name == other.Name &&
                   Info == other.Info &&
                   Cost == other.Cost &&
                   Category == other.Category &&
                   Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj.GetType() == this.GetType() && Equals((Item)obj);
        }

        public int CompareTo(Item obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return 0;
            }
            if (ReferenceEquals(null, obj))
            {
                return 1;
            }
            else
            {
                return _cost.CompareTo(obj._cost);
            }
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
            if (obj is Item other)
            {
                return CompareTo((Item)obj);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool operator ==(Item left, Item right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right)
        {
            return !Equals(left, right);
        }
    }
}
