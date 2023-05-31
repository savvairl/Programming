using Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Model.Services;
using Newtonsoft.Json.Linq;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит значение, указывающее, что поля доступны только для чтения.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Хранит значение, указывающее, что выбран контакт из списка.
        /// </summary>
        [ObservableProperty]
        private bool _isSelected;

        /// <summary>
        /// Хранит выбранный контакт.
        /// </summary>
        private Contact? _selectedContact;

        /// <summary>
        /// Хранит копию контакта.
        /// </summary>
        [ObservableProperty]
        private Contact? _contactCopy;

        /// <summary>
        /// Хранит экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        [ObservableProperty]
        private ContactVM _contactVM = new ContactVM();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.Load();

            AddContactCommand = new RelayCommand(AddContactCommandExecute);
            EditContactCommand = new RelayCommand(EditContactCommandExecute);
            RemoveContactCommand = new RelayCommand(RemoveContactCommandExecute);
            ApplyContactCommand = new RelayCommand(ApplyContactCommandExecute);
            GenerateContactCommand = new RelayCommand(GenerateContactCommandExecute);
        }

        /// <summary>
        /// Возвращает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Устанавливает и возвращает значение выбранного контакта.
        /// </summary>
        public Contact? SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                IsReadOnly = true;
                IsSelected = true;
                RestoreContact();

                _selectedContact = value;
                OnPropertyChanged();

                if (_selectedContact != null)
                {
                    ContactVM = new ContactVM(_selectedContact);
                }
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public RelayCommand? AddContactCommand { get; }

        /// <summary>
        /// Возвращает команду применения изменений.
        /// </summary>
        public RelayCommand? ApplyContactCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования контакта.
        /// </summary>
        public RelayCommand? EditContactCommand { get; }

        /// <summary>
        /// Возвращает команду удаления контакта.
        /// </summary>
        public RelayCommand? RemoveContactCommand { get; }

        /// <summary>
        /// Возвращает команду создания рандомного контакта.
        /// </summary>
        public RelayCommand? GenerateContactCommand { get; }

        /// <summary>
        /// Выполняет команду удаления контакта.
        /// </summary>
        private void RemoveContactCommandExecute()
        {
            if (SelectedContact == null) return;

            var indexOf = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            IsSelected = indexOf < Contacts.Count;
            if (indexOf < Contacts.Count)
            {
                SelectedContact = Contacts[indexOf];
            }
            else
            {
                IsSelected = false;
                ContactVM = new ContactVM();
            }
        }

        /// <summary>
        /// Выполняет команду редактирования контакта.
        /// </summary>
        private void EditContactCommandExecute()
        {
            ContactCopy = SelectedContact?.Clone() as Contact;
            ContactVM.IsReadOnly = false;
            IsReadOnly = false;
            IsSelected = false;
        }

        /// <summary>
        /// Выполняет команду применения изменений.
        /// </summary>
        private void ApplyContactCommandExecute()
        {
            ContactVM.IsReadOnly = true;
            IsReadOnly = true;
            IsSelected = true;

            if (ContactCopy == null)
            {
                if (SelectedContact == null) return;
                Contacts.Add(SelectedContact);
            }
            else
            {
                ContactCopy = null;
            }
        }

        /// <summary>
        /// Выполняет команду добавления контакта.
        /// </summary>
        private void AddContactCommandExecute()
        {
            SelectedContact = new Contact();
            ContactVM.IsReadOnly = false;
            IsReadOnly = false;
            IsSelected = false;
        }

        /// <summary>
        /// Сбрасывает изменения.
        /// </summary>
        private void RestoreContact()
        {
            if (ContactCopy == null) return;
            if (SelectedContact != null)
            {
                var indexOf = Contacts.IndexOf(SelectedContact);
                if (indexOf != -1)
                {
                    Contacts[indexOf] = ContactCopy;
                }
            }

            ContactCopy = null;
        }

        /// <summary>
        /// Выполняет команду генерации случайного контакта.
        /// </summary>
        private void GenerateContactCommandExecute()
        {
            var contact = ContactFactory.MakeContact();
            if (contact == null) return;
            Contacts.Add(contact);
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
