using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;
using Individual_Task.Model.Classes;

namespace Individual_Task.Model.Classes
{
    public class ProjectSerializer
    {
        /// <summary>
        /// Название файла в которого хранятся данные о продуктах.
        /// </summary>
        private static string fileName = "Products.xml";

        /// <summary>
        /// Полный путь до файла в котором хранятся данные о продуктах.
        /// </summary>
        public static string filePath = Environment.GetFolderPath
                (Environment.SpecialFolder.ApplicationData) + $"\\Greenev\\{fileName}";

        public static string path = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + $"\\Greenev\\";

        /// <summary>
        /// Сериализует данные о продуктах в JSON файл по заданному пути.
        /// </summary>
        public static void SerializeListJSON(List<Product> productList)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, productList);
            }
        }

        /// <summary>
        /// Десериализует данные из JSON файла в список с информацией о продуктах.
        /// </summary>
        public static void DeserializeListBoxJSON(List<Product> productList)
        {
            if (File.Exists(filePath))
            {
                JsonSerializer JsonSerializer = new JsonSerializer();
                using (StreamReader streamReader = new StreamReader(filePath))
                using (JsonReader jsonReader = new JsonTextReader(streamReader))
                {
                    try
                    {
                        JArray loadedArray = (JArray)JsonSerializer.Deserialize(jsonReader);
                        productList.AddRange(loadedArray.ToObject<List<Product>>());
                    }
                    catch (JsonSerializationException serializationException)
                    {
                        MessageBox.Show($"Serialization error. A new file will be created." +
                            $"\n{serializationException}");
                    }
                }
            }
        }
    }
}