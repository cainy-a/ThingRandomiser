using System;
using System.Collections.Generic;

namespace ThingRandomiser
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.Write("How many things do you want?");
            short amount = Convert.ToInt16(Console.ReadLine());
            List<string> things = new List<string>(amount);

            for (int i = 0; i < amount; i++)
            {
                Console.Write($"Enter Thing {(i + 1).ToString()}:");
                things.Add(Console.ReadLine());
            }

            Console.WriteLine($"I choose: \"{things[rand.Next(things.Count)]}\" as my random pick.");
        }
    }
}
