namespace calculator;

internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Operator (+ - * /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
                break;

            case '-':
                Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
                break;

            case '*':
                Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
                break;

            case '/':
                Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
                break;

            default:
                Console.WriteLine("Error: Invalid operator entered.");
                break;
        }
    }
}
