using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                if ((convert2(convert1(i)) != i))
                {
                    Console.WriteLine("error");
                }
            }
        }
        public static string convert1 (int n1)
        {
            string n2 = "";
            while (n1 > 0)
            {
                n2 = (n1%2).ToString() + n2;
                n1/=2;
            }
            return n2;
        }
        public static int convert2(string n1)
        {
            int[] n2 = n1.Select(i => Int32.Parse(i.ToString())).ToArray();
            int n3=0;
            for (int i=0; i<n2.Length; i++)
            {
                if (n2[i] == 1)
                {
                    n2[i] = 2;
                }
            }
            Array.Reverse(n2);
            if (n2.FirstOrDefault() == 2)
            {
                n3 += 1;
            }
            for (int i = 1; i < n2.Length; i++)
            {
                n3 += Convert.ToInt32(Math.Pow(n2[i],i));
            }
            return n3;
        }
    }
}
