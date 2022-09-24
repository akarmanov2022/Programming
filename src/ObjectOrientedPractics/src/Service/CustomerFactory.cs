using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service
{
    public static class CustomerFactory
    {
        private static readonly HttpClient Http = new HttpClient();

        public static List<Customer> RandomGenerate(int count)
        {
            try
            {
                var uri = $"https://api.randomdatatools.ru/?count={count}&unescaped=true&params=LastName,FirstName,FatherName,Address";
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
}