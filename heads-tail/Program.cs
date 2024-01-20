Random coin = new Random();
int flip = coin.Next(0, 2);
//.WriteLine((flip == 0) ? "heads" : "tails");
Console.WriteLine("Heads or Tails?");

Console.Write("Enter your guess: ");
var guess = Console.ReadLine();

var flipResult = flip == 0 ? "heads" : "tails";

Console.WriteLine($"\nFlip result: {flipResult}");
Console.WriteLine($"Your guess: {guess}");

if (guess.ToLower() == flipResult)
    Console.WriteLine("You win!");
else
    Console.WriteLine("You lose!");