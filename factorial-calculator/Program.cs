internal class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("Factorial Calculator!\n");
            Console.Write("Enter a whole number: ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            int factorialNum = 1;
            for (int index = 1; index <= numInput; index++)
            {
                factorialNum *= index;
            }
            Console.WriteLine($"\nThe Factorial of {numInput} is: {factorialNum}.");

            Console.WriteLine("Press any key to calculate again...");
            Console.ReadKey();
            Console.Clear();
        } while (true);

    }
}
