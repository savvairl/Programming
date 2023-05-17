using Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public partial class ContactVM : ObservableValidator
    {   /// <summary>
        /// Хранит контакт.
        /// </summary>
        private readonly Contact? _contact;

        /// <summary>
        /// Хранит значение, указывающее, что поля доступны только для чтения.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        public ContactVM(Contact? contact)
        {
            _contact = contact;
            ValidateAllProperties();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        public ContactVM()
        {
            _contact = null;
        }

        /// <summary>
        /// Устанавливает и возвращает значение Имени контакта.
        /// </summary>
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string? Name
        {
            get
            {
                return _contact?.Name;
            }
            set
            {
                if (_contact == null) return;
                _contact.Name = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Устанавливает и возвращает значение номера телефона контакта.
        /// </summary>
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        [Phone(ErrorMessage = "Phone Number can contains only digits and symbols '+()- '. Example: +7 (999) 111-22-33")]
        public string? PhoneNumber
        {
            get
            {
                return _contact?.PhoneNumber;
            }
            set
            {
                if (_contact == null) return;
                _contact.PhoneNumber = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Устанавливает и возвращает значение адреса электронной почты контакта.
        /// </summary>
        [EmailAddress]
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string? Email
        {
            get
            {
                return _contact?.Email;
            }
            set
            {
                if (_contact == null) return;
                _contact.Email = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }
    }
}
