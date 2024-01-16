using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        Dice dice = new Dice();

        string strRolls;
        int intRolls;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
        strRolls = System.Console.ReadLine();
        intRolls = int.Parse(strRolls);

        dice.Roll(intRolls);
    }
}