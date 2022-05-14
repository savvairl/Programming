using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв английского алфавита.</param>
        /// <param name="number">Номер телефона. Должен состоять только из цифр.
        /// Должен содержать 11 символов.</param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Surname), value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Должен состоять только из цифр.
        /// Должен содержать 11 символов.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                Validator.AssertValueContainsOnlyDigits(nameof(Number), value);
                Validator.AssertNumberContainsElevenDigits(nameof(Number), value);
                _number = value;
            }
        }
    }
}
