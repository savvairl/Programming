using System.Collections.Generic;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        private bool _isPrioritized;

        /// <summary>
        /// Создаёт экземпляр класс <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPrioritized = false;
            Discounts = new List<IDiscount>();
        }

        /// <summary>
        /// Создаёт экземпляр класс <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя. Размер строки должен быть до 200 символов.</param>
        /// <param name="address">Адрес. Размер строки должен быть до 500 символов.</param>
        public Customer(string fullname, Address address, Cart cart, List<Order> orders, bool isPrioritized)
        {
            Fullname = fullname;
            Address = address;
            Cart = cart;
            Orders = orders;
            IsPrioritized = isPrioritized;
            _allCustomersCount++;
            _id = _allCustomersCount;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(nameof(Fullname), 200, value);
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию заказов.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт bool:
        /// является ли покупатель приоритетным.
        /// </summary>
        public bool IsPrioritized
        {
            get
            {
                return _isPrioritized;
            }
            set
            {
                _isPrioritized = value;
            }
        }

        public List<IDiscount> Discounts { get; set; }
    }
}
