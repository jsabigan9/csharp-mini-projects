namespace grade_checker;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Checker Program");

        Console.Write("Enter your exam score: ");
        string scoreInput = Console.ReadLine();

        if (!int.TryParse(scoreInput, out int score))
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric score.");
            return;
        }

        char grade = (score >= 90) ? 'A' :
                     (score >= 80 && score <= 89) ? 'B' :
                     (score >= 70 && score <= 79) ? 'C' :
                     (score >= 60 && score <= 69) ? 'D' :
                     'F';

        Console.WriteLine($"Your grade is {grade}.");
    }
}
