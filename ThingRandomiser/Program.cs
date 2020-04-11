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

            int counter = 0;
            while (things.Count > 0)
            {
                counter++;
                int chosenNum = rand.Next(things.Count);
                Console.WriteLine($"Pick number {counter.ToString()} is: \"{things[chosenNum]}\"");
                things.RemoveAt(chosenNum);
            }
        }
    }
}
