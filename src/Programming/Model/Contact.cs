using System;

namespace Programming.Model
{
    public class Contact
    {
        private string _number;

        private string _name;

        private string _surname;

        public Contact()
        {

        }

        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = AssertStringContainsOnlyLetters(nameof(Name), value);
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters(nameof(Surname), value);
            }
        }

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

        private string AssertStringContainsOnlyLetters(string propertyName, string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"Значение {propertyName} должно содержать только буквы");
                }
            }

            return value;
        }
    }
}
