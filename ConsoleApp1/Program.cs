using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
            };
            foreach (var number in numbers) Console.WriteLine($"{number.Key} - {number.Value}");
        }
    }
}