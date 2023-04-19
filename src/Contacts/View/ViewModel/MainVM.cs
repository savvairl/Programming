using View.Model;
using View.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главное окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand), nameof(RemoveContactCommand))]
        private ContactVM _selectedContact;

        /// <summary>
        /// Значение свойства окна IsReadOnly.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Значение свойства окна Visibility.
        /// </summary>
        [ObservableProperty]
        private bool _isVisible = false;

        /// <summary>
        /// Была ли нажата кнопка Apply.
        /// </summary>
        private bool _isApply = false;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.Load();
        }

        /// <summary>
        /// Возвращает и задает индекс текущего контакты.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact { get; private set; } = new Contact();

        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; private set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает и задает значение редактора контактов.
        /// </summary>
        public bool IsEdit { get; set; }

        /// <summary>
        /// Возвращает и задает значение нажатия кнопки.
        /// </summary>
        public bool IsApply
        {
            get
            {
                return _isApply;
            }
            set
            {
                _isApply = value;

                if (value)
                {
                    IsEdit = false;
                    IsVisible = false;
                    IsReadOnly = true;
                }
                else
                {
                    IsVisible = true;
                    IsReadOnly = false;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return Contact.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Принимает добавление/изменение контакта.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (!IsEdit)
            {
                Contacts.Add(SelectedContact);
                SelectedContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                Contacts[SelectedIndex] = SelectedContact;
                SelectedContact = Contacts[SelectedIndex];
            }

            IsApply = true;
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            SelectedContact = ContactFactory.MakeContact();

            IsApply = false;
        }

        /// <summary>
        /// Изменяет контакт.
        /// </summary> 
        [RelayCommand(CanExecute = nameof(CanExecuteEdit))]
        private void EditContact()
        {
            IsEdit = true;

            var contact = SelectedContact;
            SelectedContact = (ContactVM)contact.Clone();

            IsApply = false;
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteRemove))]
        private void RemoveContact()
        {
            if (Contacts.Count == 1)
            {
                Contacts.Remove(SelectedContact);
            }
            else if (SelectedIndex < Contacts.Count - 1)
            {
                Contacts.Remove(SelectedContact);
                SelectedContact = Contacts[SelectedIndex];
            }
            else
            {
                Contacts.Remove(SelectedContact);
                SelectedContact = Contacts[SelectedIndex - 1];
            }
        }

        partial void OnSelectedContactChanged(ContactVM value)
        {
            if (!IsEdit && Contacts.Contains(value))
            {
                SelectedIndex = Contacts.IndexOf(value);
            }

            if (!IsApply)
            {
                IsApply = true;
            }
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="EditCommand"/>.
        /// </summary>
        private bool CanExecuteEdit()
        {
            return Contacts.Count > 0 && SelectedContact != null;
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        private bool CanExecuteRemove()
        {
            return Contacts.Count > 0 && SelectedContact != null;
        }

        /// <summary>
        /// Сохраняет список контактов.
        /// </summary>
        public void Save()
        {
            ContactSerializer.Save(Contacts);
        }
    }
}
