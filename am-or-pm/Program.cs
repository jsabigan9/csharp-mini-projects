int hourInput;
bool isInRange = false;
bool isNumber = false;

do
{
    Console.Write("Enter the hour in 24-hour format: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out hourInput))
    {
        Console.WriteLine("\nError: Your input is not a number!\n");

    }
    else if (!(hourInput >= 1 && hourInput <= 24))
    {
        Console.WriteLine("\nError: Your input is not in range (1 - 24)!\n");
    }
    else
    {
        //exit the loop if the user enters a valid input
        isInRange = true;
        isNumber = true;
    }
} while (!isInRange && !isNumber);

string result = (hourInput <= 11) ? $"It's {hourInput}:00 AM" :
                    (hourInput == 12) ? $"It's {hourInput}:00 NOON" :
                                        $"It's {hourInput - 12}:00 PM";

Console.WriteLine(result);