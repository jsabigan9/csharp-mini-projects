string permissionAccess;
int accessLevel;

Console.Write("Enter your Permission Access [ Admin | Manager ]: ");
permissionAccess = Console.ReadLine().ToUpper();

Console.Write("Enter your Access Level: ");
accessLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (permissionAccess.Contains("ADMIN"))
{
    if (accessLevel > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else if (accessLevel <= 55)
        Console.WriteLine("Welcome, Admin user.");
}
else if (permissionAccess.Contains("MANAGER"))
{
    if (accessLevel >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else if (accessLevel < 20)
        Console.WriteLine("You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}