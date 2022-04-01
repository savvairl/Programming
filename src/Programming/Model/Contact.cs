﻿using System;

namespace Programming.Model
{
    public class Contact
    {
        private string _number;

        public Contact()
        {

        }

        public Contact(string firstname, string lastname, string number)
        {
            Firstname = firstname;
            Lastname = lastname;
            Number = number;
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (!long.TryParse(value, out long num))
                {
                    throw new ArgumentException("Номер должно состоять только из цифр");
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 цифр");
                }

                _number = value;
            }
        }
    }
}
