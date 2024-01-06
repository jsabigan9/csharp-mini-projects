internal class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    static void MainMenu()
    {
        Console.Clear();
        DisplayMenu("Welcome to the Unit Converter!\n");
        DisplayMenu("(1) Feet And Inch Converter.");
        DisplayMenu("(2) Exit the program");


        while (true)
        {
            string stringinput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringinput, out intInput) || intInput < 1 || intInput > 2)
            {
                DisplayErrorMessage("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            switch (intInput)
            {
                case 1:
                    FeetAndInchConverter();
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

    static void FeetAndInchConverter()
    {
        Console.Clear();
        const double InchesPerFoot = 12;

        DisplayMenu("Welcome to the Feet And Inch Converter.!\n");
        DisplayMenu("(1) Convert Feet To Inch.");
        DisplayMenu("(2) Convert Inch To Feet.");
        DisplayMenu("(3) Back To Main Menu.");

        while (true)
        {
            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 3)
            {
                DisplayErrorMessage("Invalid choice. Please enter 1, 2, or 3!");
                continue;
            }

            switch (intInput)
            {
                case 1:
                    break;
                case 2:

                    return;
                case 3:
                    MainMenu();
                    break;
                default:
                    DisplayErrorMessage("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }

        /*double result;
        const double InchesPerFoot = 12;
        result = feetInput * InchesPerFoot;
        DisplayResultMessage(feetInput, result);

        return result;*/
    }

    //Messages
    #region
    static void DisplayMenu(string message)
    {
        Console.WriteLine(message);
    }
    static void DisplayResultMessage(double valueInput, double result)
    {
        Console.WriteLine($"{valueInput} is equals to {result} inches");
    }

    static void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }

    static void ThankyouMessage(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }
    #endregion

}
