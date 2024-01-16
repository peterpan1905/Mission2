using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Dice
    {
        public string[] Roll(int rolls)
        {
            // Instance of the Random class to be used when rolling the dice
            Random random = new Random();

            // Array to hold 11 values (2-12)
            int[] results = new int[11];
            // An array to hold a string of asterisks equal to the percentage each number was rolled
            string[] asterisks = new string[11];

            // Roll two die as many times as the user input. Generate random numbers. Add those numbers and save the result to the results array
            for (int i =0; i < rolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sum = die1 + die2;

                // Add one to the corresponding position of the array (If a two was rolled it will be stored in position 0, because 2 - 2 = 0)
                results[sum - 2]++;
            }

            // Calculate the percentage that each number was rolled and output that to the console
            for (int i = 0; i < results.Length; i++)
            {
                // Calculate percentage of rolls each number had
                float percentage = (float)results[i] / rolls * 100;
                int roundedPercentage = (int)System.Math.Round(percentage, 0);

                // Create a string of asterisks to be saved to the asterisks array to be printed out in place of the percentage number
                for (int j = 0; j < roundedPercentage; j++)
                {
                    asterisks[i] = asterisks[i] + "*";
                }
            }
            // Returns the array of asterisks
            return asterisks;
        }
    }
}
