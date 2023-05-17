using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Хранит имя.
        /// </summary>
        private string? _name = "";

        /// <summary>
        /// Хранит адрес электронной почты.
        /// </summary>
        private string? _email = "";

        /// <summary>
        /// Хранит номер телефона.
        /// </summary>
        private string? _phoneNumber = "";

        /// <summary>
        /// Задает значение поля и вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetField(ref _name, value);
            }
        }


        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                SetField(ref _phoneNumber, value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                SetField(ref _email, value);
            }
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="Contact"/>.</returns>
        public object Clone()
        {
            return new Contact
            {
                Name = Name,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Устанавливает значение поля и вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="field">Имя поля.</param>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <typeparam name="T">Тип поля.</typeparam>
        /// <returns>Возвращает <see langword="true"/> если значение поля было изменено, иначе <see langword="false"/>.</returns>
        private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
