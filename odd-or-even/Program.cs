namespace odd_or_even;

internal class Program
{

    static void Main(string[] args)
    {
        bool playAgain = false;
        int inputtedNumber;

        do
        {
            Console.Write("Enter a whole number:  ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out inputtedNumber))
            {
                if (double.TryParse(input, out _))
                {
                    Console.WriteLine("Your input is not a whole number!\n");
                }
                if (char.TryParse(input, out _))
                {
                    Console.WriteLine("Your input is not a number!\n");
                }
            }
            else
            {
                string result = inputtedNumber % 2 == 0 ? "Even" : "Odd";

                Console.WriteLine($"The number {inputtedNumber} is an {result} number.");

                Console.Write("Do you want to check another number? (y/n) ");
                string playAgainInput = Console.ReadLine();
                playAgain = (playAgainInput.ToLower() == "y") ? true : false;
            }

        } while (playAgain);
    }
}
