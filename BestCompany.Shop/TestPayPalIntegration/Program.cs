using System;
using System.Net.Http;

namespace TestPayPalIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();

            var response = httpClient.GetAsync("https://paypal.com");

            Console.WriteLine("Hello World!");
        }
    }
}
