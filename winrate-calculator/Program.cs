class DisplayMenu
{
    public DisplayMenu()
    {
        Console.WriteLine("Welcome to the Player Wins Calculator!");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Enter the total games played and wins for a player.");
        Console.WriteLine("The program will calculate the win rate and display statistics.\n");
    }
}

class PlayerStats
{
    private int totalGamesPlayed;
    private int wins;

    public int TotalGamesPlayed
    {
        get { return totalGamesPlayed; }
        set
        {
            if (value <= 0)
                totalGamesPlayed = 0;
            else
                totalGamesPlayed = value;
        }
    }

    public int Wins
    {
        get { return wins; }
        set
        {
            if (value <= 0)
                wins = 0;
            else
                wins = value;
        }
    }

    public double WinRate()
    {
        if (totalGamesPlayed <= 0)
            return 0;

        return (double)wins / totalGamesPlayed * 100;
    }

    public void DisplayStatistics()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Total Games Played: {TotalGamesPlayed}");
        Console.WriteLine($"Wins: {Wins}");
        Console.WriteLine($"Win Rate: {WinRate():F2}%");
    }
}

class Program
{
    static void Main()
    {

        var player = new PlayerStats();
        var menu = new DisplayMenu();

        Console.Write("Enter your Total Games Played: ");

        while (true)
        {
            var totalGamesPlayedInput = Console.ReadLine();
            if ((!int.TryParse(totalGamesPlayedInput, out int intTotalGamesPlayedInput)) || intTotalGamesPlayedInput <= 0)
            {
                Console.WriteLine("Error! Please input positive integer...");
                continue;
            }
            else
            {
                player.TotalGamesPlayed = intTotalGamesPlayedInput;
                break;
            }
        }
        Console.Write("Enter your Wins: ");

        while (true)
        {
            var totalGamesPlayed = player.TotalGamesPlayed;
            var totalWinsInput = Console.ReadLine();
            if ((!int.TryParse(totalWinsInput, out int intTotalWinsInput)) || intTotalWinsInput < 0)
            {
                Console.WriteLine("Error! Please input positive integer...");
                continue;
            }
            else if (intTotalWinsInput > totalGamesPlayed)
            {
                Console.WriteLine("Error! Total wins can't be greater than total games played...");
                continue;
            }
            else
            {
                player.Wins = intTotalWinsInput;
                break;
            }
        }

        player.DisplayStatistics();

    }

}
