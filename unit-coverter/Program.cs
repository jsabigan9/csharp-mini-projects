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
                    var feetInput = GetFeetFromUser();
                    ConvertFeetToInch(feetInput);
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

    static double GetFeetFromUser()
    {
        while (true)
        {
            Console.Write("\nEnter a value in feet: ");
            string inputString = Console.ReadLine();

            if (double.TryParse(inputString, out double feetInput) && feetInput >= 0)
            {
                return feetInput;
            }
            else
            {
                DisplayErrorMessage("Please enter a valid positive numeric input.");
            }
        }
    }
    static double ConvertFeetToInch(double feetInput)
    {
        double result;
        const double InchesPerFoot = 12;
        result = feetInput * InchesPerFoot;
        DisplayResultMessage(feetInput, result);

        return result;
    }

    static void DisplayResultMessage(double feetInput, double result)
    {
        Console.WriteLine($"{feetInput} is equals to {result} inches");
    }

    static void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }
}
