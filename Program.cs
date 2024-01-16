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

        dice.Roll(intRolls);
    }
}