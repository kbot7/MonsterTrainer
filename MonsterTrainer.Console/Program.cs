internal class Program
{
    static void Main(string[] args)
    {
        // Declare global game variables
        var randomizer = new Random(DateTime.Now.Nanosecond);
        string playerName = string.Empty;
        int playerScore = 0;
        int currentWeek = 0;

        // Configure Game
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Do you want to set your own name? Y or N");
        var nameInputSwitch = Console.ReadLine();
        if (nameInputSwitch == "Y")
        {
            Console.WriteLine("What's your player name?");
            var playerNameInput = Console.ReadLine();
            playerName = playerNameInput;
        }
        else if (nameInputSwitch == "N")
        {
            string[] randomNamePossibilities = ["Poopsmith", "Asseater", "Motor boat enthusiast", "Thigh fucker", "The cast of King of the Hill"];

            int randoIndex = randomizer.Next(0, randomNamePossibilities.Length);
            playerName = randomNamePossibilities[randoIndex];
        }
        Console.WriteLine("Welcome to the game, " + playerName);

        // Core game loop
        while (currentWeek < 10)
        {
            // Iterate week
            currentWeek = currentWeek + 1;
            Console.WriteLine("It is week " + currentWeek);

            // Present menu to player
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[B] to Battle, [T] to Training, [R] to Rest, or [I] to use Items");

            // Wait for user input
            var userMenuSelection = Console.ReadLine();

            if (userMenuSelection == "B")
            {
                // Start Battle
            }
            if (userMenuSelection == "T")
            {
                // Start Training
            }
            if (userMenuSelection == "R")
            {
                // Start Rest
            }
            if (userMenuSelection == "I")
            {
                // Use Item
            }
        }

        // Game Ends
        Console.WriteLine("Game finished");

    }
}