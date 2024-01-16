using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create instance of Dice class found in Dice.cs
        Dice dice = new Dice();

        // Create string and integer variables to convert user input to integer
        string strRolls;
        int intRolls;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
        strRolls = System.Console.ReadLine();
        // Convert user input number to integer
        intRolls = int.Parse(strRolls);

        // Collect an array of asterisks to be printed as the results
        string[] output = dice.Roll(intRolls);

        // Explain the output to the user
        System.Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {intRolls}\n");
        // Loop through the output array to print the corresponding asterisks
        for (int i = 0; i < output.Length; i++)
        {
            System.Console.WriteLine($"{i + 2}: {output[i]}");
        }
        // Thank the user for using the program
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}