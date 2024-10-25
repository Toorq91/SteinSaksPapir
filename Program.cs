class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Choose [R]ock, [P]aper, or [S]cissors:");

            // Get user input
            string playerChoice = Console.ReadLine().ToUpper();
            while (playerChoice != "R" && playerChoice != "P" && playerChoice != "S")
            {
                Console.WriteLine("Invalid choice. Please choose [R]ock, [P]aper, or [S]cissors:");
                playerChoice = Console.ReadLine().ToUpper();
            }

            // Generate computer choice
            string[] choices = { "R", "P", "S" };
            Random random = new Random();
            string computerChoice = choices[random.Next(choices.Length)];

            Console.WriteLine($"Computer chose: {DisplayChoice(computerChoice)}");
            Console.WriteLine($"You chose: {DisplayChoice(playerChoice)}");

            // Determine the winner
            string result = DetermineWinner(playerChoice, computerChoice);
            Console.WriteLine(result);

            // Ask to play again
            Console.WriteLine("Do you want to play again? (Y/N)");
            playAgain = Console.ReadLine().ToUpper() == "Y";
        }
    }

    static string DisplayChoice(string choice)
    {
        return choice switch
        {
            "R" => "Rock",
            "P" => "Paper",
            "S" => "Scissors",
            _ => "Invalid"
        };
    }

    static string DetermineWinner(string player, string computer)
    {
        if (player == computer)
            return "It's a tie!";

        if ((player == "R" && computer == "S") ||
            (player == "P" && computer == "R") ||
            (player == "S" && computer == "P"))
        {
            return "You win!";
        }

        return "Computer wins!";
    }
}
