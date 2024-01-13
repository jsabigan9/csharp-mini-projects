
internal class Program
{
    static void Main(string[] args)
    {
        MainMenu();
    }

    #region Start Program
    static void MainMenu()
    {
        DisplayMenu("Welcome to the Unit Converter!\n");
        DisplayMenu("(1) Feet Converter");
        DisplayMenu("(2) Inch Converter");
        DisplayMenu("(3) Centimeter Converter");
        DisplayMenu("(4) Meter Converter");
        DisplayMenu("(5) Exit the program\n");

        while (true)
        {
            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 5)
            {
                DisplayError("Invalid choice. Please enter 1, 2, 3, 4 or 5.");
                continue;
            }

            switch (intInput)
            {
                case 1: Console.Clear(); FeetConverter(); return;
                case 2: Console.Clear(); InchConverter(); return;
                case 3: Console.Clear(); CentimeterConverter(); return;
                case 4: Console.Clear(); MeterConverter(); return;
                case 5: Console.WriteLine("\nThank you for using the Unit Converter!"); return;
                default: return;
            }
        }
    }
    #endregion


    #region FeetConverter
    static void FeetConverter()
    {


        DisplayMenu("Welcome to the Feet Converter!\n");
        DisplayMenu("(1) Convert Feet Value");
        DisplayMenu("(2) Back to Main Menu");

        while (true)
        {

            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 4)
            {
                DisplayError("Invalid choice. Please enter 1, 2, 3, or 4!!!\n");
                continue;
            }

            switch (intInput)
            {
                case 1: FeetConvertion(); return;
                case 2: Console.Clear(); MainMenu(); return;
                default: return;
            }
        }
        static void FeetConvertion()
        {
            const double InchesPerFoot = 12;
            const double CentimetersPerFoot = 30.48;
            const double MetersPerFoot = 0.3048;

            while (true)
            {
                Console.Clear();
                DisplayMenu("FEET CONVERTER\n");
                var feetInput = GetFeetInput();

                Console.Clear();
                DisplayResult($"ft: {feetInput}\n");
                DisplayResult($"in: {feetInput * InchesPerFoot:F2}");
                DisplayResult($"cm: {feetInput * CentimetersPerFoot:F2}");
                DisplayResult($"m: {feetInput * MetersPerFoot:F2}");

                DisplayMenu("\n(1) Convert Another Value");
                DisplayMenu("(2) Back To Main Menu");

                while (true)
                {
                    string input = Console.ReadLine().ToLower();
                    if (!int.TryParse(input, out int intInput) || (intInput < 1 || intInput > 2))
                    {
                        DisplayError("Please enter 1 or 2");
                        continue;
                    }

                    switch (intInput)
                    {
                        case 1: Console.Clear(); FeetConvertion(); return;
                        case 2: Console.Clear(); MainMenu(); return;
                        default: return;
                    }
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
                        DisplayError("Please enter a valid positive numeric input.\n");
                        continue;
                    }
                    return intInput;
                }
            }
        }
    }
    #endregion

    #region InchConverter
    static void InchConverter()
    {


        DisplayMenu("Welcome to the Inch Converter!\n");
        DisplayMenu("(1) Convert Inch Value");
        DisplayMenu("(2) Back to Main Menu");

        while (true)
        {

            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 4)
            {
                DisplayError("Invalid choice. Please enter 1 or 2!!!\n");
                continue;
            }

            switch (intInput)
            {
                case 1: InchConvertion(); return;
                case 2: Console.Clear(); MainMenu(); return;
                default: return;
            }
        }
        static void InchConvertion()
        {
            const double FootPerInch = 0.083333;
            const double CentimetersPerInch = 2.54;
            const double MetersPerInch = 0.0254;

            while (true)
            {
                Console.Clear();
                DisplayMenu("INCH CONVERTER\n");
                var inchInput = GetInchInput();

                Console.Clear();
                DisplayResult($"in: {inchInput}\n");

                DisplayResult($"ft: {inchInput * FootPerInch:F4}");
                DisplayResult($"cm: {inchInput * CentimetersPerInch:F4}");
                DisplayResult($"m: {inchInput * MetersPerInch:F4}");

                DisplayMenu("\n(1) Convert Another Value");
                DisplayMenu("(2) Back To Main Menu");

                while (true)
                {
                    string input = Console.ReadLine().ToLower();
                    if (!int.TryParse(input, out int intInput) || (intInput < 1 || intInput > 2))
                    {
                        DisplayError("Please enter 1 or 2");
                        continue;
                    }

                    switch (intInput)
                    {
                        case 1: Console.Clear(); InchConvertion(); return;
                        case 2: Console.Clear(); MainMenu(); return;
                        default: return;
                    }
                }
            }

            static double GetInchInput()
            {
                while (true)
                {
                    Console.Write("Enter Inch Value: ");
                    string inputString = Console.ReadLine();

                    if ((!double.TryParse(inputString, out double intInput)) || intInput <= 0)
                    {
                        DisplayError("Please enter a valid positive numeric input.\n");
                        continue;
                    }
                    return intInput;
                }
            }
        }
    }
    #endregion

    #region CentimeterConverter
    static void CentimeterConverter()
    {


        DisplayMenu("Welcome to the Centimeter Converter!\n");
        DisplayMenu("(1) Convert Centimeter Value");
        DisplayMenu("(2) Back to Main Menu");

        while (true)
        {

            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 4)
            {
                DisplayError("Invalid choice. Please enter 1 or 2!!!\n");
                continue;
            }

            switch (intInput)
            {
                case 1: CentimeterConvertion(); return;
                case 2: Console.Clear(); MainMenu(); return;
                default: return;
            }
        }
        static void CentimeterConvertion()
        {
            const double CentimeterPerFoot = 30.48;
            const double CentimeterPerInch = 2.54;
            const double CentimeterPerMeter = 100;

            while (true)
            {
                Console.Clear();
                DisplayMenu("CENTIMETER CONVERTER\n");
                var centimeterInput = GetCentimeterInput();

                Console.Clear();
                DisplayResult($"cm: {centimeterInput}\n");

                DisplayResult($"ft: {centimeterInput / CentimeterPerFoot:F4}");
                DisplayResult($"in: {centimeterInput / CentimeterPerInch:F4}");
                DisplayResult($"m: {centimeterInput / CentimeterPerMeter:F4}");

                DisplayMenu("\n(1) Convert Another Value");
                DisplayMenu("(2) Back To Main Menu");

                while (true)
                {
                    string input = Console.ReadLine().ToLower();
                    if (!int.TryParse(input, out int intInput) || (intInput < 1 || intInput > 2))
                    {
                        DisplayError("Please enter 1 or 2");
                        continue;
                    }

                    switch (intInput)
                    {
                        case 1: Console.Clear(); CentimeterConvertion(); return;
                        case 2: Console.Clear(); MainMenu(); return;
                        default: return;
                    }
                }
            }

            static double GetCentimeterInput()
            {
                while (true)
                {
                    Console.Write("Enter Centimeter Value: ");
                    string inputString = Console.ReadLine();

                    if ((!double.TryParse(inputString, out double intInput)) || intInput <= 0)
                    {
                        DisplayError("Please enter a valid positive numeric input.\n");
                        continue;
                    }
                    return intInput;
                }
            }
        }
    }

    #endregion

    #region MeterConverter
    static void MeterConverter()
    {


        DisplayMenu("Welcome to the Meter Converter!\n");
        DisplayMenu("(1) Convert Meter Value");
        DisplayMenu("(2) Back to Main Menu");

        while (true)
        {

            string stringInput = Console.ReadLine();
            int intInput;

            if (!int.TryParse(stringInput, out intInput) || intInput < 1 || intInput > 4)
            {
                DisplayError("Invalid choice. Please enter 1 or 2!!!\n");
                continue;
            }

            switch (intInput)
            {
                case 1: MeterConvertion(); return;
                case 2: Console.Clear(); MainMenu(); return;
                default: return;
            }
        }
        static void MeterConvertion()
        {
            const double MeterPerFoot = .3048;
            const double MeterPerInch = 0.0254;
            const double MeterPerCentimeter = 0.01;

            while (true)
            {
                Console.Clear();
                DisplayMenu("METER CONVERTER\n");
                var meterInput = GetMeterInput();

                Console.Clear();
                DisplayResult($"m: {meterInput}\n");

                DisplayResult($"ft: {meterInput / MeterPerFoot:F2}");
                DisplayResult($"in: {meterInput / MeterPerInch:F2}");
                DisplayResult($"cm: {meterInput / MeterPerCentimeter:F2}");

                DisplayMenu("\n(1) Convert Another Value");
                DisplayMenu("(2) Back To Main Menu");

                while (true)
                {
                    string input = Console.ReadLine().ToLower();
                    if (!int.TryParse(input, out int intInput) || (intInput < 1 || intInput > 2))
                    {
                        DisplayError("Please enter 1 or 2");
                        continue;
                    }

                    switch (intInput)
                    {
                        case 1: Console.Clear(); MeterConvertion(); return;
                        case 2: Console.Clear(); MainMenu(); return;
                        default: return;
                    }
                }
            }

            static double GetMeterInput()
            {
                while (true)
                {
                    Console.Write("Enter Meter Value: ");
                    string inputString = Console.ReadLine();

                    if ((!double.TryParse(inputString, out double intInput)) || intInput <= 0)
                    {
                        DisplayError("Please enter a valid positive numeric input.\n");
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
    static void DisplayResult(string message)
    {
        Console.WriteLine(message);
    }

    static void DisplayError(string message)
    {
        Console.WriteLine($"\nError: {message}\n");
    }
    #endregion

}