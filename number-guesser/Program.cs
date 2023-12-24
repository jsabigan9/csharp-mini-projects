using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = false;

        do
        {
            int guessAttempts = 0;
            int randomNumber = random.Next(1, 8);
            int guess = 0;

            Console.WriteLine("Welcome to Number Guesser Game!");
            Console.WriteLine("Guess the Number from 1 to 7!");
            Console.WriteLine("You have 3 attempts to guess the number, Good luck!");
            Console.WriteLine("");

            while (guessAttempts < 3)
            {
                Console.Write("Enter your guess: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                if (guess > 7 || guess < 1) //Fix input not on 1 to 7 range
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
                    continue;
                }

                guessAttempts++; // Iterates every guess attempt

                if (guess == randomNumber)
                {

                    Console.WriteLine($"You Guessed the Number, which is {randomNumber}, on attempt {guessAttempts}!");
                    break; // Correct guess, break out of the loop
                }

                if (guessAttempts < 3)
                {

                    Console.WriteLine("Incorrect Guess. Try Again:");
                }
                else
                {

                    Console.WriteLine("Incorrect Guess"); // Incorrect guess on 3rd attempt, no "Try Again" message
                }

                if (guessAttempts == 2)
                {

                    if (guess > randomNumber) // Display hint after the 2nd attempt
                    {
                        Console.WriteLine("Hint: Your guess is Higher than the Random Number!");
                    }
                    else
                    {
                        Console.WriteLine("Hint: Your guess is Lower than the Random Number!");
                    }
                }
            }

            if (guess != randomNumber)
            {
                // Used all attempts without a correct guess, GAME OVER!
                Console.WriteLine($"Sorry, you've used all your attempts. The correct number was {randomNumber}.");
            }

            Console.WriteLine("Do You Want To Play Again? Y|N");
            string response = Console.ReadLine();

            if (response.Equals("y", StringComparison.OrdinalIgnoreCase)) //Ignore Case of the input
            {

                Console.Clear();
                playAgain = true;
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
                playAgain = false;
            }

        } while (playAgain);
    }
}