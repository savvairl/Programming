using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        /// <summary>
        /// Хранит путь до AppData.
        /// </summary>
        private static string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создает покупателя.
        /// </summary>
        /// <returns>Возвращает объект Customer.</returns>
        public static Customer CreateCustomer()
        {
            Address address = new Address();
            address.Index = 123456;
            address.Country = "Russia";
            address.City = "Tomsk";
            address.Street = "Nahimova";
            address.Building = "71";
            address.Apartment = "15";

            Customer customer = new Customer();
            customer.Fullname = "Ivan Ivanovich Ivanov";
            customer.Address = address;
            customer.Cart = new Cart();
            customer.Discounts.Add(new PointsDiscount());

            return customer;
        }
    }
}
