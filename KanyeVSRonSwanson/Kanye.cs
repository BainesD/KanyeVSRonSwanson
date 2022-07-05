using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeVSRonSwanson
{
    internal static class Kanye
    {
        public static void Speak()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeRequest = client.GetStringAsync(kanyeURL).Result;
            var kanyeTest = JObject.Parse(kanyeRequest).GetValue("quote").ToString();
            Console.WriteLine(kanyeTest);
        }
    }
}
