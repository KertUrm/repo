﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var states = new Dictionary<string, String>();
            states.Add("Estonia","EST");
            states.Add("Latvia", "LAT");
            states.Add("Finland", "FIN");
            states.Add("Sweden", "SWE");

            foreach (var state in states) Console.WriteLine($"{state.Key} - {state.Value}");

            Console.WriteLine(states["Latvia"]);
            Console.WriteLine(states["Estonia"]);

            if (states.ContainsKey("Estonia")) Console.WriteLine(states["Estonia"]);
            else Console.WriteLine("Ei ole riiki");
        }
    }
}
