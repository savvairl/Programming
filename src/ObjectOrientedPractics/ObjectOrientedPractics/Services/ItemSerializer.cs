using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    public static class ItemSerializer
    {
        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(string path, List<Item> items)
        {
            using (StreamWriter writer = new StreamWriter(path + @"\SerializedData1.json"))
            {
                writer.Write(JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Item> Deserialize(string path)
        {
            var items = new List<Item>();

            try
            {
                using (StreamReader reader = new StreamReader(path + @"\SerializedData1.json"))
                {
                    items = JsonConvert.DeserializeObject<List<Item>>(reader.ReadToEnd());
                }

                if (items == null)
                {
                    items = new List<Item>();
                }
            }
            catch
            {
                return items;
            }

            return items;
        }
    }
}
