using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Dice
    {
        public void Roll(int rolls)
        {
            Random random = new Random();

            int[] results = new int[11];

            for (int i =0; i < rolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sum = die1 + die2;

                results[sum - 2]++;
            }

            System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {rolls}\n");
            for (int i = 0; i < results.Length; i++)
            {
                string[] asterisks = new string[11];

                // Calculate percentage of rolls each number had
                float percentage = (float)results[i] / rolls * 100;
                int roundedPercentage = (int)System.Math.Round(percentage, 0);

                for (int j = 0; j < roundedPercentage; j++)
                {
                    asterisks[i] = asterisks[i] + "*";
                }
                System.Console.WriteLine($"{i + 2}: {asterisks[i]}");
            }
            System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
