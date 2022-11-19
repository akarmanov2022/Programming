using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Статический класс с набором методов для конвертирования объектов в строку json, и наоборот.
    /// </summary>
    /// <typeparam name="T">Тип данных для сериализации/десериализации.</typeparam>
    public static class Serializer<T>
    {
        public static void ToJson(T o, string filePath)
        {
            var serializer = new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };  

            using (var sw = new StreamWriter(filePath))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, o);
            }
        }

        public static T FromJson(string filePath)
        {
            var serializer = new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };  

            using (var sr = new StreamReader(filePath, false))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<T>(reader);
            }
        }
    }
}