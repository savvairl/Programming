using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    public static class ContactSerializer
    {
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
