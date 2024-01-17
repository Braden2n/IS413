using System;

namespace Mission2
{
    internal class DiceRoller
    {
        // RNG Generator
        private readonly Random rnd = new Random();
        // Constructor
        public DiceRoller() { }
        // Simulator of `num_rolls` two-dice rolls
        public int[] Simulate(int num_rolls)
        {
            // Result array with pos. 0-10 (2-12 - 2)
            int[] roll_results = new int[11];
            for (int i = 0; i < num_rolls; i++)
            {
                // Addition of the RNG will be 2-12 - adjusting for 0-10 pos.
                roll_results[rnd.Next(1, 7) + rnd.Next(1, 7) - 2]++;
            }
            return roll_results;
        }
    }
}