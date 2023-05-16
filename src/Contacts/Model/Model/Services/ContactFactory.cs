namespace Model.Model.Services
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
        public static Contact MakeContact()
        {
            var contact = new Contact();
            contact.Name = "Jesus Christ Евгеньевич";
            contact.PhoneNumber = "+7 (988) 988-16-04";
            contact.Email = "jesuschrist@gmail.com";

            return contact;
        }
    }
}