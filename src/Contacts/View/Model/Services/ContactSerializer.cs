using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию по сериализации данных.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Выполняет сериализацию данных.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        /// <param name="path">Путь.</param>
        public static void Serialize(Contact contact, string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Выполняет десериализацию данных.
        /// </summary>
        /// <param name="path">Путь.</param>
        /// <returns>Экземпляр класса <see cref="Contact"/>.</returns>
        public static Contact Deserialize(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            var contact = new Contact();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
                }

                if (contact == null)
                {
                    contact = new Contact();
                }
            }
            catch (FileNotFoundException ex)
            {
                return contact;
            }

            return contact;
        }
    }
}
