using System;
using Mission2;

namespace Mission2
{
    internal class Simulate
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());
            // Calculating how many values a single percent is
            float one_percent = (float)rolls / 100;
            if (one_percent < 0)
            {
                one_percent = 1 / one_percent;
            }
            DiceRoller roller = new DiceRoller();
            int[] results = roller.Simulate(rolls);
            Console.WriteLine("\nSIMULATION RESULTS\nEach \"*\" represents 1% of the total rolls\nTotal rolls = " + rolls + "\n");
            for (int i = 0; i < results.Length; i++)
            {
                // Calculating what percentage of rolls the value had
                int percentage = Convert.ToInt32(Math.Floor(results[i] / one_percent));
                Console.WriteLine((i + 2) + ":\t" + new string('*', percentage));
            }
        }
    }
}