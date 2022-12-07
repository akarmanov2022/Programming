using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service;

/// <summary>
/// Статическая фабрика для создания экземпляров <see cref="Item"/>.
/// </summary>
public static class ItemFactory
{
    private static readonly HttpClient Http = new();

    public static IEnumerable<Item> RandomGenerate(int count)
    {
        try
        {
            var uri = $"https://api.randomdatatools.ru/?count={count}&unescaped=true&params=CarBrand,CarModel";
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = Http.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;
            var items = JsonSerializer.Deserialize<List<Item>>(json);

            var random = new Random();
            var categories = Enum.GetValues(typeof(Category));
            items?.ForEach(item =>
            {
                item.Cost = Math.Round(random.NextDouble() * 100000);
                item.Category = (Category)categories.GetValue(random.Next(categories.Length - 1));
            });
            return items;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}