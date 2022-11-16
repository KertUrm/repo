using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            string a = "a";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a=a+"a");
            }
        }
    }
}
