using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerSerializer
    {
        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(string path, List<Customer> customers)
        {
            using (StreamWriter writer = new StreamWriter(path + @"\SerializedData2.json"))
            {
                writer.Write(JsonConvert.SerializeObject(customers));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Customer> Deserialize(string path)
        {
            var customers = new List<Customer>();

            try
            {
                using (StreamReader reader = new StreamReader(path + @"\SerializedData2.json"))
                {
                    customers = JsonConvert.DeserializeObject<List<Customer>>(reader.ReadToEnd());
                }

                if (customers == null)
                {
                    customers = new List<Customer>();
                }
            }
            catch
            {
                return customers;
            }

            return customers;
        }
    }
}
