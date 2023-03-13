using System.IO;
using Newtonsoft.Json;

namespace Contacts.Services;

/// <summary>
/// Статический класс с набором методов для преобразования объектов в строку json, и наоборот.
/// </summary>
/// <typeparam name="T">Тип данных для сериализации/десериализации.</typeparam>
public static class Serializer<T>
{
    public static void ToJson(T o, string filePath)
    {
        using var sw = new StreamWriter(filePath);
        var serializer = new JsonSerializer();
        serializer.Serialize(sw, o);
    }

    public static T FromJson(string filePath)
    {
        using var sr = new StreamReader(filePath);
        var serializer = new JsonSerializer();
        return (T)serializer.Deserialize(sr, typeof(T))!;
    }
}