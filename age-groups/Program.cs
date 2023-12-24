namespace age_groups;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Determine if you're and Child, Teenager, Adult, or Senior!");
        Console.WriteLine("\n -_-_-_-_-_-_-_-_-_-_-_-_-_- \n");

        Console.Write("Enter your Name: ");
        string nameInput = Console.ReadLine();

        Console.Write("Enter your Age: ");
        int ageInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n -_-_-_-_-_-_-_-_-_-_-_-_-_- \n");

        
        if (ageInput < 12)
        {
            Console.WriteLine($"Welcome {nameInput.ToUpper()}, You're a Child.");
        }
        else if ((ageInput >= 13) && (ageInput <= 19))
        {
            Console.WriteLine($"Welcome {nameInput.ToUpper()}, You're a Teenager.");
        }
        else if ((ageInput >= 20) && (ageInput <= 64))
        {
            Console.WriteLine($"Welcome {nameInput.ToUpper()}, You're an Adult.");
        }
        else
        {
            Console.WriteLine($"Welcome {nameInput.ToUpper()}, You're a Senior.");
        }


        Console.ReadKey();
    }
}
