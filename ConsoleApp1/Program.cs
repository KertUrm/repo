using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite football player t-shirt number!");
            string number = Console.ReadLine();
            int numberConverted = Convert.ToInt32(number);

            // teen siia if ja elsi loogikaga vastused
            // nt kui on  alla 50 , siis tuleb console writeline vastus 
            if (numberConverted <= 50)
            {
                Console.WriteLine("Number on väiksem või võrdne kui 50");
            }
            else
            {
                Console.WriteLine("Number on suurem kui 50");
            }
        }
    }
}
