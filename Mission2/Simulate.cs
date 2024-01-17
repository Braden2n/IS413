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
            // Calculating what 1% of rolls is
            float one_percent = (float)rolls / 100;
            // Instantiate simulator
            DiceRoller roller = new DiceRoller();
            // Getting array of simulated results
            int[] results = roller.Simulate(rolls);
            Console.WriteLine("\nSIMULATION RESULTS\nEach \"*\" represents 1% of the total rolls\nTotal rolls = " + rolls + "\n");
            for (int i = 0; i < results.Length; i++)
            {
                // Displaying one asterisks per percentage each value had
                Console.WriteLine((i + 2) + ":\t" + new string(
                    '*', Convert.ToInt32(Math.Floor(results[i] / one_percent
                ))));
            }
        }
    }
}