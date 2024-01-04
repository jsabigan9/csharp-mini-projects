internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine();
            int choiceInt;

            if (!int.TryParse(choice, out choiceInt) || choiceInt < 1 || choiceInt > 2)
            {
                DisplayErrorMessage("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            switch (choiceInt)
            {
                case 1:
                    ConvertFeetToInches();
                    return;
                case 2:
                    Console.WriteLine("\nThank you for using the Feet to Inches Converter!");
                    return;
                default:
                    DisplayErrorMessage("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Feet to Inches Converter!");
        Console.WriteLine("(1) Enter a new value in feet.");
        Console.WriteLine("(2) Exit the program.");
    }

    static void ConvertFeetToInches()
    {
        const int InchesPerFoot = 12;

        while (true)
        {
            Console.Write("\nEnter a value in feet: ");
            string inputString = Console.ReadLine();

            if (!double.TryParse(inputString, out double feetInput) || feetInput < 0)
            {
                DisplayErrorMessage("Please enter a valid positive numeric input.");
                continue;
            }
            else
            {
                double convertedInch = feetInput * InchesPerFoot;
                Console.WriteLine($"\n{feetInput} feet is equal to {convertedInch:F2} inches.\n");
                break;
            }
        }
    }

    static void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }
}
