using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public partial class Contact : ObservableObject, INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Хранит имя.
        /// </summary>
        [ObservableProperty]
        private string? _name = "";

        /// <summary>
        /// Хранит адрес электронной почты.
        /// </summary>
        [ObservableProperty]
        private string? _email = "";

        /// <summary>
        /// Хранит номер телефона.
        /// </summary>
        [ObservableProperty]
        private string? _phoneNumber = "";

        public object Clone()
        {
            return new Contact
            {
                Name = Name,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
        }

        public override string ToString()
        {
            return $"{Name} {PhoneNumber}";
        }
    }
}
