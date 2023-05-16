using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Model.Model.Services
{
    /// <summary>
    /// Представляет реализацию по сериализации данных.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public static string Path { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public static ObservableCollection<Contact> Load()
        {
            var contacts = new ObservableCollection<Contact>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts =
                        JsonConvert.DeserializeObject<ObservableCollection<Contact>>(sr.ReadToEnd());
                }
            }
            else
            {
                File.Create(Path).Close();
            }

            return contacts;
        }

        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void Save(ObservableCollection<Contact> contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(JsonConvert.SerializeObject(contacts));
            }
        }
    }
}
