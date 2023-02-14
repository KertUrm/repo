using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domains = new Dictionary<string, string>()
            {
                {"est","Estonia"},
                {"lat","Latvia" },
                {"fin","Finland" },
                {"swe","Sweden" }
            };
            domains.ToList().ForEach(e => Console.WriteLine($"{e.Key} - {e.Value}"));
        }
    }
}
