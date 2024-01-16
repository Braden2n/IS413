using System;

namespace Mission2
{
    /// <summary>
    /// Class <c>DiceRoller</c> manages the simulation of rolling 2 dice n times.
    /// </summary>
    internal class DiceRoller
    {
        // Single instande of Random generator
        private readonly Random rnd = new Random();
        public DiceRoller() { }
        /// <summary>
        /// Method <c>Simulate</c> simulates the rolling of two dice num_rolls times.
        /// Method <c>Roll</c> is called to simulate a two-dice roll.
        /// Array of 11 occurences  is returned (pos[0] == 2; pos[10] == 12)
        /// </summary>
        public int[] Simulate(int num_rolls)
        {
            // Empty array for incrementing
            int[] roll_results = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < num_rolls; i++)
            {
                // Roll will return a minimum of 2, which gets adjusted to pos[0]
                roll_results[Roll() - 2] += 1;
            }
            return roll_results;
        }
        /// <summary>
        /// Simulates the rolling of two dice.
        /// </summary>
        private int Roll()
        {
            // Two random rolls are made
            return rnd.Next(1, 7) + rnd.Next(1,7);
        }
    }
}