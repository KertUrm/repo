using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tänavad = new Dictionary<string, string>()
            {
                {"Otepää","Jaani tänav"},
                {"Tartu","Aasa tänav"},
                {"Haapsalu","Ehte tänav"},
                {"Narva","Männi tänav"}
            };
            foreach (var tänav in tänavad)
            {
                Console.WriteLine($"{tänav.Key} - {tänav.Value}");
            }
        }
    }
}
