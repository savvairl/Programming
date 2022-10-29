using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

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
        /// Создаёт экземпляр класс <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Создаёт экземпляр класс <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя. Размер строки должен быть до 200 символов.</param>
        /// <param name="address">Адрес. Размер строки должен быть до 500 символов.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
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
    }
}
