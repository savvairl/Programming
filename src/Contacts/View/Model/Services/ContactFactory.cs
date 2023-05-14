using View.ViewModel;
using View.Model;

namespace View.Model.Services
{
    /// <summary>
    /// Хранит логику для автоматического создания объектов.
    /// </summary>
    public static class ContactFactory
    {
        /// <summary>
        /// Создает объект с данными.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public static ContactVM MakeContact()
        {
            var contact = new Contact();
            contact.Name = "Jesus Christ Евгеньевич";
            contact.PhoneNumber = "89889881604";
            contact.Email = "jesuschrist@gmail.com";
            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
