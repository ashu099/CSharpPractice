using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<int, string> numbers = new Dictionary<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "two");
            numbers.Add(3, "Three");
            // numbers.Add(3, "four");
            numbers.Add(4, "Three");
            numbers.Add(5, null);// allowed because in dictionary values can be dulicate and null


            var cities = new Dictionary<string, string>()
            {
                { "USA","NYK, washington,Chicago" },
                { "India","Delhi, Mumbai,Kolkata"} };

            foreach (var item in cities)
            {
                Console.WriteLine("key:{0},Value:{1}",item.Key,item.Value);

            }
            Console.WriteLine(cities.TryGetValue("France", out string value));
            Console.WriteLine(cities.ContainsKey("India"));
            Console.WriteLine(cities.ContainsValue("India"));

            //  cities.Remove(null);//not allowed 

            cities["India"] = "satna";//update is possible
            cities["France"] = "Paris";//addes new intry if key is not present
            cities["Pakistan"] = "";//allowed
            cities.Clear();
            Console.WriteLine("Hello World!");
        }
    }
}
