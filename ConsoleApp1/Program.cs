using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, String>()
            {
                {"Harju","Tallinn" },
                {"Läänemaa","Haapsalu" },
                {"Raplamaa","Rapla" },
            };
            cities.Remove("Harju");

            if (cities.ContainsKey("Läänemaa")) cities.Remove("Läänemaa");

            Console.WriteLine(cities.Count);
        }
    }
}
