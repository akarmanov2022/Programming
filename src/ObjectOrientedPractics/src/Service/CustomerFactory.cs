﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service;

/// <summary>
/// Статическая фабрика для создания экземпляров <see cref="Customer"/>.
/// </summary>
public static class CustomerFactory
{
    private static readonly HttpClient Http = new();

    /// <summary>
    /// Генерирует случайные <see cref="Customer"/> через ресурс <c>api.randomdatatools.ru</c>.
    /// </summary>
    /// <param name="count">Количество элементов.</param>
    /// <returns>Список <see cref="Customer"/>.</returns>
    public static IEnumerable<Customer> RandomGenerate(int count)
    {
        try
        {
            var uri = $"https://api.randomdatatools.ru/?count={count}&unescaped=true&params=LastName,FirstName,FatherName";
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
                
            var response = Http.SendAsync(request).Result;

            var json = response.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<List<Customer>>(json);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}