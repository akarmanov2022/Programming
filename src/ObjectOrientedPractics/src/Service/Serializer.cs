using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Service
{
    public static class Serializer<T>
    {
        public static void ToJson(T o, string filePath)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, o);
            }
        }

        public static T FromJson(string filePath)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(filePath, false))
            using (var reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<T>(reader);
            }
        }
    }
}