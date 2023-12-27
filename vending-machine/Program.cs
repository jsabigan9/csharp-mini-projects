using System.Reflection.Metadata.Ecma335;

namespace vending_machine

{
    class Program
    {
        static void Main(string[] args)
        {

            string option1 = @"1. Chips             $1.50",
                   option2 = @"2. Chocolate Bar     $2.00",
                   option3 = @"3. Soda              $1.25",
                   option4 = @"4. Water             $1.00";
            double insertedMoney;
            int choice;

            Console.WriteLine("Vending Machine Menu:");
            Console.WriteLine("****************************");
            Console.WriteLine(option1);
            Console.WriteLine(option2);
            Console.WriteLine(option3);
            Console.WriteLine(option4);
            Console.WriteLine("****************************\n");

            Console.Write("\nEnter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            double change = 0;
            switch (choice)
            {

                case 1:

                    Console.WriteLine($"\nYou have selected Chips for $1.50");

                    Console.Write("\nInsert Money: ");
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    change = insertedMoney - 1.50;

                    if (change >= 0)
                    {
                        Console.WriteLine($"\nPurchase successful! Your change is ${change:F2}");
                    }
                    else
                    {
                        Console.WriteLine("\nNot enough money inserted. Please insert at least $1.50.");
                    }
                    break;

                case 2:

                    Console.WriteLine($"\nYou have selected Chocolate Bar for $2.00");

                    Console.Write("\nInsert Money: ");
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    change = insertedMoney - 2;

                    if (change >= 0)
                    {
                        Console.WriteLine($"\nPurchase successful! Your change is ${change:F2}");
                    }
                    else
                    {
                        Console.WriteLine("\nNot enough money inserted. Please insert at least $2.00.");
                    }
                    break; ;

                case 3:

                    Console.WriteLine($"\nYou have selected Soda for $1.25");

                    Console.Write("\nInsert Money: ");
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    change = insertedMoney - 1.25;

                    if (change >= 0)
                    {
                        Console.WriteLine($"\nPurchase successful! Your change is ${change:F2}");
                    }
                    else
                    {
                        Console.WriteLine("\nNot enough money inserted. Please insert at least $1.25.");
                    }
                    break;

                case 4:

                    Console.WriteLine($"\nYou have selected Water for $1.00");

                    Console.Write("\nInsert Money: ");
                    insertedMoney = Convert.ToDouble(Console.ReadLine());
                    change = insertedMoney - 1;

                    if (change >= 0)
                    {
                        Console.WriteLine($"\nPurchase successful! Your change is ${change:F2}");
                    }
                    else
                    {
                        Console.WriteLine("\nNot enough money inserted. Please insert at least $1.00.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    return;

            }
        }
    }
}
