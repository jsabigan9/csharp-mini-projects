
internal class Program
{
    static void Main(string[] args)
    {
        StartProgram();
    }

    #region Start Program
    static void StartProgram()
    {
        DisplayMenu("Welcome to the Unit Converter!\n");
        DisplayMenu("(1) Feet Converter");
        DisplayMenu("(2) Exit the program");

        while (true)
        {
            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 2)
            {
                DisplayErrorMessage("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            switch (intInput)
            {
                case 1: Console.Clear(); FeetConverter(); return;
                case 2: DisplayThankyouMessage("\nThank you for using the Unit Converter!"); return;
                default: return;
            }
        }
    }
    #endregion

    #region FeetConverter
    static void FeetConverter()
    {
        const double InchesPerFoot = 12;
        const double CentimetersPerFoot = 30.48;
        const double MetersPerFoot = 0.3048;
        const double KilometersPerFoot = 0.0003048;

        DisplayMenu("Welcome to the Feet Converter!\n");
        DisplayMenu("(1) Convert to inches");
        DisplayMenu("(2) Convert to centimeters");
        DisplayMenu("(3) Convert to meters");
        DisplayMenu("(4) Convert to kilometers");
        DisplayMenu("(5) Back to Main Menu");

        while (true)
        {

            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 6)
            {
                DisplayErrorMessage("Invalid choice. Please enter 1, 2, 3, 4, or 5!!!\n");
                continue;
            }

            switch (intInput)
            {
                case 1: FeetToInchConvertion(); return;
                case 2: return;
                case 3: return;
                case 4: return;
                case 5: Console.Clear(); StartProgram(); return;
                default: return;
            }
        }
        static void FeetToInchConvertion()
        {
            const double FeetToInch = 12;

            while (true)
            {
                Console.Clear();
                DisplayMenu("Feet To Inch Converter\n");
                var feetInput = GetFeetInput();

                Console.Clear();
                DisplayResultMessage($"FEET: {feetInput}");
                DisplayResultMessage($"INCH: {feetInput * FeetToInch:F2}");

                DisplayMenu("\n(1) Convert Another Value");
                DisplayMenu("(2) Back To Previos Main Menu");
                DisplayMenu("(3) Back To Main Menu");
                string input = Console.ReadLine().ToLower();

                if ((!int.TryParse(input, out int intInput)) || (intInput < 1 && intInput > 3))
                {
                    DisplayErrorMessage("Please enter a 1, 2, or 3!\n");
                    continue;
                }
                switch (intInput)
                {
                    case 1: Console.Clear(); FeetToInchConvertion(); return;
                    case 2: Console.Clear(); FeetConverter(); return;
                    case 3: Console.Clear(); StartProgram(); return;
                    default: return;
                }
            }

            static double GetFeetInput()
            {
                while (true)
                {
                    Console.Write("Enter Feet Value: ");
                    string inputString = Console.ReadLine();

                    if ((!double.TryParse(inputString, out double intInput)) || intInput <= 0)
                    {
                        DisplayErrorMessage("Please enter a valid positive numeric input.\n");
                        continue;
                    }
                    return intInput;
                }
            }
        }
    }
    #endregion

    #region Messages
    static void DisplayMenu(string message)
    {
        Console.WriteLine(message);
    }
    static void DisplayResultMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }

    static void DisplayThankyouMessage(string message)
    {
        Console.WriteLine($"\n{message}\n");
    }
    #endregion

}